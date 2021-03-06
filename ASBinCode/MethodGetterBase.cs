﻿using System;
using System.Collections.Generic;
using System.Text;
using ASBinCode.rtData;

namespace ASBinCode
{
    public abstract class MethodGetterBase : LeftValueBase,IMember
    {
        protected readonly ASBinCode.rtti.Class _class;
        protected int indexofMember;
        
        private readonly string _name;

        public readonly int refdefinedinblockid;

        protected int functionid;
        public void setFunctionId(int functionid)
        {
            this.functionid = functionid;
        }

        public int functionId
        {
            get { return functionid; }
        }

        /// <summary>
        /// 比如说，私有方法就肯定不是虚方法
        /// </summary>
        protected bool isNotReadVirtual = false;
        public void setNotReadVirtual()
        {
            isNotReadVirtual = true;
        }

        public MethodGetterBase(string name, rtti.Class _class,int indexofMember
            ,int refdefinedinblockid
            )
        {
            this._class = _class;
            this.indexofMember = indexofMember;
            this._name = name;
            this.refdefinedinblockid = refdefinedinblockid;

            this.valueType = RunTimeDataType.rt_function;

        }

        public ASBinCode.rtti.ClassMember classmember
        {
            get
            {
                return _class.classMembers[indexofMember];
            }
        }

        //public sealed override  RunTimeDataType valueType
        //{
        //    get
        //    {
        //        return RunTimeDataType.rt_function;
        //    }
        //}

        public string name
        {
            get
            {
                return _name;
            }
        }

        public int indexOfMembers
        {
            get
            {
                return indexofMember;
            }
        }

        private static MethodSlot _temp= MethodSlot.instance;

        public sealed override SLOT getSlotForAssign(RunTimeScope scope, RunTimeDataHolder holder)
        {
            return _temp;
        }

        public sealed override  SLOT getSlot(RunTimeScope scope, RunTimeDataHolder holder)
        {
            throw new NotImplementedException();


            //var vmember=(ClassMethodGetter)((rtObject)scope.this_pointer).value._class.classMembers[indexofMember].bindField;

            //rtData.rtFunction method = new rtData.rtFunction(vmember.functionid, true);
            //method.bind(scope);
            //method.setThis(scope.this_pointer);
            //return new MethodSlot(method);


            //rtData.rtFunction method = new rtData.rtFunction(functionid, true);
            //method.bind(scope);
            //method.setThis(scope.this_pointer);
            //return new MethodSlot(method);

        }


        //private MethodSlot _tempSlot;

        //public abstract RunTimeValueBase getValue(RunTimeScope scope);


        /// <summary>
        /// 如果此方法是一个构造函数。。在InstanceCreator中调用
        /// </summary>
        /// <param name="scope"></param>
        /// <returns></returns>
        public abstract RunTimeValueBase getConstructor(RunTimeScope scope);


        public abstract RunTimeValueBase getMethod(rtObject rtObj);

        public abstract RunTimeValueBase getMethod(RunTimeScope scope);


        public abstract RunTimeValueBase getSuperMethod(RunTimeScope scope, ASBinCode.rtti.Class superClass);



        //public abstract SLOT getVirtualSlot(RunTimeScope scope);


        //public abstract SLOT getSuperSlot(RunTimeScope scope, ASBinCode.rtti.Class superClass);
        






        public IMember clone()
        {
            throw new NotImplementedException();
            //return new ClassMethodGetter(_name, _class, indexofMember, refdefinedinblockid);
        }

        public override string ToString()
        {
            return name;
        }

        //public override int GetHashCode()
        //{
        //    return _name.GetHashCode() ^ _class.GetHashCode() ^ indexofMember.GetHashCode() ^ refdefinedinblockid.GetHashCode(); 
        //}

        //public override bool Equals(object obj)
        //{
        //    if (obj == null) { return false; }

        //    if (!(obj.GetType().Equals(this.GetType())))
        //    {
        //        return false;
        //    }

        //    ClassMethodGetter other = (ClassMethodGetter)obj;
        //    return _name == other._name &&
        //        _class == other._class &&
        //        indexofMember == other.indexofMember &&
        //        refdefinedinblockid == other.refdefinedinblockid;

        //}

        public sealed class MethodSlot : SLOT
        {
            //private rtFunction method;
            public static MethodSlot instance = new MethodSlot();
            
            private MethodSlot()
            {
                
                //this.method = method;
            }
            
            public sealed override void clear()
            {

            }

            public sealed override bool directSet(RunTimeValueBase value)
            {
                return false;
            }

            public sealed override RunTimeValueBase getValue()
            {
                throw new NotImplementedException();
            }

            public sealed override void setValue(rtNull value)
            {
                throw new NotImplementedException();
            }

            public sealed override void setValue(rtUndefined value)
            {
                throw new NotImplementedException();
            }

            public sealed override void setValue(string value)
            {
                throw new NotImplementedException();
            }

            public sealed override void setValue(int value)
            {
                throw new NotImplementedException();
            }

            public sealed override void setValue(uint value)
            {
                throw new NotImplementedException();
            }

            public sealed override void setValue(double value)
            {
                throw new NotImplementedException();
            }

            public sealed override void setValue(rtBoolean value)
            {
                throw new NotImplementedException();
            }
        }
    }
}
