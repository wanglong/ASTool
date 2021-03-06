﻿using ASBinCode;
using ASBinCode.rtData;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASRuntime.operators
{
    /// <summary>
    /// 动态属性
    /// </summary>
    class OpDynamicProperty
    {
        public static void exec_delete(StackFrame frame,OpStep step, RunTimeScope scope)
        {
            {
                StackSlot slot = (StackSlot)((Register)step.arg1).getSlot(scope,frame);
                if (slot.linktarget is DynamicPropertySlot)
                {
                    DynamicPropertySlot link = (DynamicPropertySlot)slot.linktarget;
                    if (link._canDelete)
                    {
                        ((ASBinCode.rtti.DynamicObject)link.obj.value).deleteProperty(link._propname);
                    }
                    else
                    {
                        if (link.backup != null)
                        {
                            link.directSet(link.backup);
                        }
                    }
                }
                else if (slot.linktarget is DictionarySlot)
                {
                    DictionarySlot link = (DictionarySlot)slot.linktarget;
                    ((ASBinCode.rtti.DictionaryObject)link.obj.value).RemoveKey(link._key);
                }
                else if (slot.linktarget is OpAccess_Dot.arraySlot) //(slot.fromArray != null)
                {
                    slot.directSet(rtUndefined.undefined);
                    //slot.fromArray.innerArray[slot.fromArrayIndex] = rtUndefined.undefined;
                }
                else if (slot.linktarget is OpAccess_Dot.prototypeSlot)
                {   //原型链对象，不可删除

                }
                else if (slot.linktarget is OpVector.vectorSLot)
                {
                    //数组链接，跳过
                }
                else
                {
                    frame.throwError(
                        step.token, 0,
                                    "动态属性才能被delete"
                        );

                }

                frame.endStep(step);
            }
        }


        public static void exec_set_dynamic_prop(StackFrame frame, OpStep step, RunTimeScope scope)
        {
            ASBinCode.rtData.rtObject obj = (ASBinCode.rtData.rtObject)step.reg.getValue(scope, frame);
            ASBinCode.rtti.DynamicObject dobj = (ASBinCode.rtti.DynamicObject)obj.value;

            DynamicPropertySlot heapslot = new DynamicPropertySlot(obj, true,frame.player.swc.FunctionClass.getRtType());
            heapslot._propname = ((ASBinCode.rtData.rtString)step.arg1.getValue(scope, frame)).value;

            if (step.arg2 is MethodGetterBase)
            {
                heapslot.directSet( ((MethodGetterBase)step.arg2).getMethod(scope));
            }
            else
            {
                heapslot.directSet(step.arg2.getValue(scope, frame));
            }

            //dobj.createOrReplaceproperty(heapslot._propname,heapslot);
            if (dobj.hasproperty(heapslot._propname))
            {
                dobj.deleteProperty(heapslot._propname);
            }
            dobj.createproperty(heapslot._propname, heapslot);
            //直接初始化，可枚举
            heapslot.propertyIsEnumerable = true;
            frame.endStep(step);
        }
    }
}
