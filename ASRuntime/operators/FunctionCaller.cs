﻿using ASBinCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASRuntime.operators
{
    class FunctionCaller : IBlockCallBack
    {
        private static Stack<FunctionCaller> pool;
        static FunctionCaller()
        {
            pool = new Stack<FunctionCaller>();
            for (int i = 0; i < 128; i++)
            {
                pool.Push(new FunctionCaller(null, null, null));
            }
        }
        
        public static FunctionCaller create(Player player, StackFrame invokerFrame, SourceToken token)
        {
            FunctionCaller fc = pool.Pop();
            fc.player = player;
            fc.invokerFrame = invokerFrame;
            fc.token = token;

            fc.check_para_id = 0;
            fc.pushedArgs = 0;
            fc.hasReleased = false;
            
            return fc;
        }

        public static void checkpool()
        {
            if (pool.Count != 128)
            {
                throw new ASRunTimeException("缓存池异常");
            }
        }

        private static void ret(FunctionCaller c)
        {
            pool.Push(c);
        }


        private HeapSlot[] CallFuncHeap;

        public ASBinCode.rtData.rtFunction function;
        public ASBinCode.rtti.FunctionDefine toCallFunc;

        public int pushedArgs;

        public SLOT returnSlot;

        public SLOT _tempSlot;

        public IBlockCallBack callbacker;


        public Player player;
        private StackFrame invokerFrame;
        private SourceToken token;
        private int check_para_id;

        private FunctionCaller(Player player,StackFrame invokerFrame, SourceToken token)
        {
            this.player = player;
            this.invokerFrame = invokerFrame;
            this.token = token;

            check_para_id = 0;
            pushedArgs = 0;
            hasReleased = false;
            
        }

        
        bool hasReleased;
        public void release()
        {
            if (!hasReleased)
            {
                hasReleased = true;
                CallFuncHeap = null;
                function = null;
                toCallFunc = null;
                pushedArgs = 0;
                returnSlot = null;
                _tempSlot = null;
                callbacker = null;
                
                player = null;
                invokerFrame = null;
                token = null;
                check_para_id = 0;

                ret(this);
            }
            
        }

        public void loadDefineFromFunction()
        {
            toCallFunc = player.swc.functions[function.functionId];
           
        }

        public bool createParaScope()
        {
            if (toCallFunc.isNative)
            {
                if (toCallFunc.native_index < 0)
                {
                    toCallFunc.native_index = player.swc.nativefunctionNameIndex[toCallFunc.native_name];
                }
                var nf = player.swc.nativefunctions[toCallFunc.native_index];
                nf.bin = player.swc;
                if (nf.mode == NativeFunctionBase.NativeFunctionMode.const_parameter_0)
                {
                    ((nativefuncs.NativeConstParameterFunction)nf).prepareParameter(toCallFunc);

                    return true;
                }
            }

            ASBinCode.rtti.FunctionSignature signature = toCallFunc.signature;

            invokerFrame.call_parameter_slotCount = signature.onStackParameters;
            if (invokerFrame.offset + 
                invokerFrame.block.totalRegisters + 1 + 1 + 
                invokerFrame.call_parameter_slotCount >= invokerFrame.stack.Length)
            {

                invokerFrame.throwError(new error.InternalError(token, "stack overflow"));
                invokerFrame.endStep();
                if (callbacker != null)
                {
                    callbacker.noticeRunFailed();
                }
                release();

                return false;
            }


            CallFuncHeap =
                player.genHeapFromCodeBlock(player.swc.blocks[toCallFunc.blockid]);

            for (int i = 0; i < signature.parameters.Count; i++)
            {
                if (signature.parameters[i].defaultValue != null)
                {
                    var dt = signature.parameters[i].type;
                    var dv = signature.parameters[i].defaultValue.getValue(null, null);


                    if (dv.rtType != dt && dt != RunTimeDataType.rt_void)
                    {
                        if (dt == RunTimeDataType.rt_int)
                        {
                            dv = new ASBinCode.rtData.rtInt(TypeConverter.ConvertToInt(dv, invokerFrame, token));
                        }
                        else if (dt == RunTimeDataType.rt_uint)
                        {
                            dv = new ASBinCode.rtData.rtUInt(TypeConverter.ConvertToUInt(dv, invokerFrame, token));
                        }
                        else if (dt == RunTimeDataType.rt_number)
                        {
                            dv = new ASBinCode.rtData.rtNumber(TypeConverter.ConvertToNumber(dv));
                        }
                        else if (dt == RunTimeDataType.rt_string)
                        {
                            dv = new ASBinCode.rtData.rtString(TypeConverter.ConvertToString(dv, invokerFrame, token));
                        }
                        else if (dt == RunTimeDataType.rt_boolean)
                        {
                            dv = TypeConverter.ConvertToBoolean(dv, invokerFrame, token);
                        }
                    }

                    //if (signature.onStackParameters > 0)
                    //{
                    //    ASBinCode.rtti.FunctionParameter fp = signature.parameters[i];

                    //    if (fp.isOnStack)
                    //    {
                    //        Register r = (Register)fp.varorreg;
                    //        int index = invokerFrame.offset + invokerFrame.block.totalRegisters + 1+1 
                    //                    + invokerFrame.call_parameter_slotCount + r._index ;
                    //        invokerFrame.stack[index].directSet(dv);
                    //    }
                    //    else
                    //    {
                    //        CallFuncHeap[ ((Variable) fp.varorreg).indexOfMembers ].directSet(
                    //            dv

                    //        );
                    //    }
                    //}
                    //else
                    //{
                    //    CallFuncHeap[i].directSet(
                    //        dv

                    //        );
                    //}
                    _storeArgementToSlot(i, dv);
                }
                else if (signature.parameters[i].isPara)
                {
                    //if (signature.onStackParameters > 0)
                    //{
                    //    ASBinCode.rtti.FunctionParameter fp = signature.parameters[i];
                    //    if (fp.isOnStack)
                    //    {
                    //        Register r = (Register)fp.varorreg;
                    //        int index = invokerFrame.offset + invokerFrame.block.totalRegisters + 1 + 1
                    //                    + invokerFrame.call_parameter_slotCount + r._index;
                    //        invokerFrame.stack[index].directSet(new ASBinCode.rtData.rtArray());
                    //    }
                    //    else
                    //    {
                    //        CallFuncHeap[((Variable)fp.varorreg).indexOfMembers].directSet(
                    //            new ASBinCode.rtData.rtArray()

                    //        );
                    //    }
                    //}
                    //else
                    //{
                    //    CallFuncHeap[i].directSet(
                    //            new ASBinCode.rtData.rtArray()
                    //        );
                    //}
                    _storeArgementToSlot(i, new ASBinCode.rtData.rtArray());
                }
                else
                {
                    _storeArgementToSlot(i, ASBinCode.rtData.rtUndefined.undefined);
                }
            }

            return true;
            
        }

        private SLOT _getArgementSlot(int id)
        {
            var signature = toCallFunc.signature;

            if (signature.onStackParameters > 0)
            {
                ASBinCode.rtti.FunctionParameter fp = signature.parameters[id];

                if (fp.isOnStack)
                {
                    Register r = (Register)fp.varorreg;
                    int index = invokerFrame.offset + invokerFrame.block.totalRegisters + 1 + 1
                                + invokerFrame.call_parameter_slotCount + r._index;
                    return invokerFrame.stack[index];
                }
                else
                {
                    return CallFuncHeap[((Variable)fp.varorreg).indexOfMembers];
                }
            }
            else
            {
                return CallFuncHeap[id];
            }
        }

        private void _storeArgementToSlot(int id,RunTimeValueBase v)
        {
            var signature = toCallFunc.signature;

            if (signature.onStackParameters > 0)
            {
                ASBinCode.rtti.FunctionParameter fp = signature.parameters[id];

                if (fp.isOnStack)
                {
                    Register r = (Register)fp.varorreg;
                    int index = invokerFrame.offset + invokerFrame.block.totalRegisters + 1 + 1
                                + invokerFrame.call_parameter_slotCount + r._index;
                    invokerFrame.stack[index].directSet(v);
                }
                else
                {
                    CallFuncHeap[((Variable)fp.varorreg).indexOfMembers].directSet(
                        v

                    );
                }
            }
            else
            {
                CallFuncHeap[id].directSet(v);
            }
        }


        public void pushParameter(RunTimeValueBase argement,int id,out bool success)
        {
            if (toCallFunc.isNative)
            {
                if (toCallFunc.native_index < 0)
                {
                    toCallFunc.native_index = player.swc.nativefunctionNameIndex[toCallFunc.native_name];
                }
                var nf = player.swc.nativefunctions[toCallFunc.native_index];
                nf.bin = player.swc;
                if (nf.mode == NativeFunctionBase.NativeFunctionMode.const_parameter_0)
                {
                    ((nativefuncs.NativeConstParameterFunction)nf).pushParameter(toCallFunc, id, argement, 
                        token,invokerFrame, out success);
                    if (success)
                    {
                        pushedArgs++;
                    }
                    else
                    {
                        if (callbacker != null)
                        {
                            callbacker.noticeRunFailed();
                        }
                    }
                    return;
                }
            }


            if (toCallFunc.signature.parameters.Count > 0 || toCallFunc.IsAnonymous)
            {
                bool lastIsPara = false;

                if (toCallFunc.signature.parameters.Count > 0 && toCallFunc.signature.parameters[toCallFunc.signature.parameters.Count - 1].isPara)
                {
                    lastIsPara = true;
                }
                
                if (!lastIsPara 
                    || id < toCallFunc.signature.parameters.Count - 1 
                    || 
                    (
                    toCallFunc.IsAnonymous  
                    &&
                    !(lastIsPara && id >= toCallFunc.signature.parameters.Count-1 )
                    )
                    
                    )
                {
                    if (id < toCallFunc.signature.parameters.Count)
                    {
                        //CallFuncHeap[id].directSet(argement);

                        _storeArgementToSlot(id, argement);

                        pushedArgs++;
                    }
                    else
                    {
                        if (!toCallFunc.IsAnonymous)
                        {
                            //参数数量不匹配
                            invokerFrame.throwArgementException(
                                token,
                                string.Format(
                                "Argument count mismatch on Function/{0}. Expected {1}, got {2}.",
                                player.swc.blocks[toCallFunc.blockid].name, toCallFunc.signature.parameters.Count, pushedArgs + 1
                                )

                                );

                            //***中断本帧本次代码执行进入try catch阶段
                            success = false;


                            if (callbacker != null)
                            {
                                callbacker.noticeRunFailed();
                            }
                            release();
                            
                            
                            return;
                        }

                    }

                }
                else
                {
                    //***最后一个是参数数组，并且id大于等于最后一个
                    SLOT slot = _getArgementSlot(toCallFunc.signature.parameters.Count - 1); //CallFuncHeap[toCallFunc.signature.parameters.Count - 1];
                    if (slot.getValue().rtType == RunTimeDataType.rt_null)
                    {
                        slot.directSet(new ASBinCode.rtData.rtArray());
                    }

                    ASBinCode.rtData.rtArray arr = (ASBinCode.rtData.rtArray)slot.getValue();
                    arr.innerArray.Add((RunTimeValueBase)argement.Clone());    //可能从StackSlot中读的数据，因此必须Clone后再传入.

                }

                success = true;
            }
            else
            {
                invokerFrame.throwArgementException(
                            token,
                            string.Format(
                            "Argument count mismatch on Function/{0}. Expected {1}, got {2}.",
                            player.swc.blocks[toCallFunc.blockid].name, toCallFunc.signature.parameters.Count, pushedArgs + 1
                            )

                            );
                success = false;


                if (callbacker != null)
                {
                    callbacker.noticeRunFailed();
                }
                release();
                
                
            }
        }

        private RunTimeValueBase getToCheckParameter(int para_id)
        {
            if (toCallFunc.isNative)
            {
                if (toCallFunc.native_index < 0)
                {
                    toCallFunc.native_index = player.swc.nativefunctionNameIndex[toCallFunc.native_name];
                }
                var nf = player.swc.nativefunctions[toCallFunc.native_index];
                nf.bin = player.swc;
                if (nf.mode == NativeFunctionBase.NativeFunctionMode.const_parameter_0)
                {
                    return ((nativefuncs.NativeConstParameterFunction)nf).getToCheckParameter(para_id);
                }
            }

            return _getArgementSlot(para_id).getValue();  //CallFuncHeap[para_id].getValue();

        }
        private void setCheckedParameter(int para_id,RunTimeValueBase value)
        {
            //CallFuncHeap[para_id].directSet(value);
            if (toCallFunc.isNative)
            {
                if (toCallFunc.native_index < 0)
                {
                    toCallFunc.native_index = player.swc.nativefunctionNameIndex[toCallFunc.native_name];
                }
                var nf = player.swc.nativefunctions[toCallFunc.native_index];
                nf.bin = player.swc;
                if (nf.mode == NativeFunctionBase.NativeFunctionMode.const_parameter_0)
                {
                    ((nativefuncs.NativeConstParameterFunction)nf)
                        .setCheckedParameter(para_id,value);
                    return;
                }
            }


            _getArgementSlot(para_id).directSet(value);
        }

        private void check_para()
        {
            while (check_para_id < pushedArgs)
            {
                //RunTimeValueBase argement = CallFuncHeap[check_para_id].getValue();
                RunTimeValueBase argement = getToCheckParameter(check_para_id);
                if (argement.rtType != toCallFunc.signature.parameters[check_para_id].type
                    &&
                    toCallFunc.signature.parameters[check_para_id].type != RunTimeDataType.rt_void
                    )
                {
                    BlockCallBackBase cb = BlockCallBackBase.create();
                    cb.args = argement;
                    cb._intArg = check_para_id;
                    cb.setCallBacker(check_para_callbacker);

                    check_para_id++;

                    OpCast.CastValue(argement, toCallFunc.signature.parameters[
                        cb._intArg].type,

                        invokerFrame, token, invokerFrame.scope, _tempSlot,cb,false);

                    
                    return;
                }
                else
                {
                    check_para_id++;
                }
            }
            //***全部参数检查通过***
            _doCall();
        }

        private void check_para_callbacker(BlockCallBackBase sender,object args)
        {
            if (sender.isSuccess)
            {
                //CallFuncHeap[sender._intArg].directSet(_tempSlot.getValue());
                setCheckedParameter(sender._intArg, _tempSlot.getValue());
                check_para();
            }
            else
            {
                throw new ASRunTimeException("解释器内部错误，参数类型检查");
                //invokerFrame.throwCastException(token, ((RunTimeValueBase)sender.args).rtType, toCallFunc.signature.parameters[sender._intArg].type);
                //return;
            }
        }

        private void _doCall()
        {
            if (pushedArgs < toCallFunc.signature.parameters.Count && !toCallFunc.IsAnonymous) //匿名函数能跳过参数检查
            {
                for (int i = pushedArgs; i < toCallFunc.signature.parameters.Count; i++)
                {
                    if (toCallFunc.signature.parameters[pushedArgs].defaultValue == null
                    &&
                    !toCallFunc.signature.parameters[pushedArgs].isPara
                    )
                    {
                        invokerFrame.throwArgementException(
                            token,
                            string.Format(
                            "Argument count mismatch on Function/{0}. Expected {1}, got {2}.",
                            player.swc.blocks[toCallFunc.blockid].name, toCallFunc.signature.parameters.Count, pushedArgs
                            )
                            
                            );

                        //***中断本帧本次代码执行进入try catch阶段
                        invokerFrame.endStep();

                        if (callbacker != null)
                        {
                            callbacker.noticeRunFailed();
                        }
                        release();
                        
                        
                        return;
                    }
                }
            }
            if (toCallFunc.isYield)
            {
                if (!player.static_instance.ContainsKey(player.swc.YieldIteratorClass.staticClass.classid))
                {
                    operators.InstanceCreator ic = new InstanceCreator(player, invokerFrame, token, player.swc.YieldIteratorClass);
                    if (!ic.init_static_class(player.swc.YieldIteratorClass))
                    {
                        invokerFrame.endStep();

                        if (callbacker != null)
                        {
                            callbacker.noticeRunFailed();
                        }
                        release();
                        
                        
                        return;
                    }

                }

                ASBinCode.rtti.YieldObject yobj = new ASBinCode.rtti.YieldObject(
                    player.swc.YieldIteratorClass);


                CallFuncHeap[CallFuncHeap.Length - 2].directSet(new ASBinCode.rtData.rtInt(1));

                yobj.argements = CallFuncHeap;
                yobj.function_bindscope = function.bindScope;
                yobj.block = player.swc.blocks[toCallFunc.blockid];
                yobj.yield_function = toCallFunc;

                
                ASBinCode.rtData.rtObject rtYield = new ASBinCode.rtData.rtObject(yobj, null);
                yobj.thispointer =
                    (function.this_pointer != null ?
                    function.this_pointer : invokerFrame.scope.this_pointer);

                RunTimeScope scope = new RunTimeScope(null,  
                     player.swc.YieldIteratorClass.blockid, null, rtYield, RunTimeScopeType.objectinstance);
                rtYield.objScope = scope;
                
                returnSlot.directSet(rtYield);

                
                if (callbacker != null)
                {
                    callbacker.call(callbacker.args);
                }
                release();
                
                return;
            }
            else if (!toCallFunc.isNative)
            {
                returnSlot.directSet(
                    TypeConverter.getDefaultValue(toCallFunc.signature.returnType).getValue(null,null));

                if (!ReferenceEquals(callbacker, this))
                {
                    //***执行完成后，先清理参数***
                    BlockCallBackBase cb = BlockCallBackBase.create();
                    cb.args = cb.cacheObjects;
                    cb.cacheObjects[0] = callbacker;
                    cb.cacheObjects[1] = invokerFrame;

                    cb.setCallBacker(callfun_cb);
                    cb.setWhenFailed(callfun_failed);

                    player.callBlock(
                        player.swc.blocks[toCallFunc.blockid],
                        CallFuncHeap,
                        returnSlot,
                        function.bindScope,
                        token, cb, function.this_pointer != null ? function.this_pointer : invokerFrame.scope.this_pointer, RunTimeScopeType.function);

                    release();
                }
                else
                {
                    player.callBlock(
                        player.swc.blocks[toCallFunc.blockid],
                        CallFuncHeap,
                        returnSlot,
                        function.bindScope,
                        token, callbacker, function.this_pointer != null ? function.this_pointer : invokerFrame.scope.this_pointer, RunTimeScopeType.function);
                }
                
            }
            else
            {
                if (toCallFunc.native_index <0)
                {
                    toCallFunc.native_index = player.swc.nativefunctionNameIndex[toCallFunc.native_name];
                }

                

                var nf = player.swc.nativefunctions[toCallFunc.native_index];
                nf.bin = player.swc;

                if (nf.mode == NativeFunctionBase.NativeFunctionMode.normal_0)
                {
                    player._nativefuncCaller = this;

                    string errormsg;
                    int errorno;
                    var result = nf.execute(
                        function.this_pointer != null ? function.this_pointer : invokerFrame.scope.this_pointer,
                        CallFuncHeap, invokerFrame,
                        out errormsg,
                        out errorno
                        );
                    player._nativefuncCaller = null;
                    if (errormsg == null)
                    {
                        returnSlot.directSet(result);
                        
                        if (callbacker != null)
                        {
                            callbacker.call(callbacker.args);
                        }
                        
                        release();
                        
                    }
                    else
                    {
                        invokerFrame.throwError(
                            token, 0, errormsg
                            );

                        invokerFrame.endStep();

                        if (callbacker != null)
                        {
                            callbacker.noticeRunFailed();
                        }
                        release();
                        
                        
                    }

                }
                else if (nf.mode == NativeFunctionBase.NativeFunctionMode.normal_1)
                {
                    player._nativefuncCaller = this;
                    bool success;

                    nf.execute2(
                        function.this_pointer != null ? function.this_pointer : invokerFrame.scope.this_pointer,
                        toCallFunc,
                        CallFuncHeap,
                        returnSlot,
                        token,
                        invokerFrame,
                        out success
                        );
                    player._nativefuncCaller = null;
                    if (success)
                    {
                        if (callbacker != null)
                        {
                            callbacker.call(callbacker.args);
                        }
                    }
                    else
                    {
                        invokerFrame.endStep();
                        if (callbacker != null)
                        {
                            callbacker.noticeRunFailed();
                        }
                        
                    }

                    release();
                    
                   
                }
                else if (nf.mode == NativeFunctionBase.NativeFunctionMode.async_0)
                {
                    nf.executeAsync(function.this_pointer != null ? function.this_pointer : invokerFrame.scope.this_pointer,
                        CallFuncHeap,
                        returnSlot,
                        callbacker,
                        invokerFrame,
                        token,
                        function.bindScope
                        );

                    if ( !ReferenceEquals(callbacker, this))
                    {
                        release();
                    }
                }
                else if (nf.mode == NativeFunctionBase.NativeFunctionMode.const_parameter_0)
                {
                    bool success;
                    player._nativefuncCaller = this;
                    ((nativefuncs.NativeConstParameterFunction)nf).execute3(
                        function.this_pointer != null ? function.this_pointer : invokerFrame.scope.this_pointer,
                        toCallFunc,
                        returnSlot,
                        token,
                        invokerFrame,
                        out success
                        );
                    player._nativefuncCaller = null;
                    ((nativefuncs.NativeConstParameterFunction)nf).clearParameter();

                    if (success)
                    {
                        if (callbacker != null)
                        {
                            callbacker.call(callbacker.args);
                        }
                    }
                    else
                    {
                        invokerFrame.endStep();
                        if (callbacker != null)
                        {
                            callbacker.noticeRunFailed();
                        }
                        
                    }

                    
                    release();
                    
                    
                }
            }
        }

        private void callfun_failed(BlockCallBackBase sender, object args)
        {
            StackFrame frame = (StackFrame)sender.cacheObjects[1];
            clear_para_slot(frame);
        }

        private static void callfun_cb(BlockCallBackBase sender, object args)
        {
            IBlockCallBack callbacker = sender.cacheObjects[0] as IBlockCallBack;
            StackFrame frame = (StackFrame)sender.cacheObjects[1];
            clear_para_slot(frame);
            if (callbacker != null)
            {
                callbacker.call(callbacker.args);
            }
            
        }

        private static void clear_para_slot(StackFrame invokerFrame)
        {
            if (invokerFrame.call_parameter_slotCount > 0)
            {
                //**清理**
                for (int i = invokerFrame.offset + invokerFrame.block.totalRegisters + 1 + 1;
                    i < invokerFrame.offset + invokerFrame.block.totalRegisters + 1 + 1 + invokerFrame.call_parameter_slotCount
                    ; i++)
                {
                    invokerFrame.stack[i].clear();
                }

                invokerFrame.call_parameter_slotCount = 0;
            }
        }


        public void call()
        {
            check_para();
        }

        object IBlockCallBack.args
        {
            get
            {
                return null;
            }

            set
            {
                ;
            }
        }

        void IBlockCallBack.call(object args)
        {
            clear_para_slot(invokerFrame);
            invokerFrame.endStep();
            release();
            
        }

        public void noticeRunFailed()
        {
            clear_para_slot(invokerFrame);
            release();
        }
    }
}
