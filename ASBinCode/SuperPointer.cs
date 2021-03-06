﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ASBinCode
{
    /// <summary>
    /// 访问父类的成员
    /// </summary>
    public sealed class SuperPointer : RightValueBase
    {
        public rtti.Class superClass;

        public rtti.Class thisClass;

        public SuperPointer(ASBinCode.rtti.Class superClass,rtti.Class thisClass)
        {
            this.superClass = superClass;
            this.thisClass = thisClass;
            valueType = superClass.getRtType();
        }


        //public sealed override  RunTimeDataType valueType
        //{
        //    get
        //    {
        //        //throw new NotImplementedException();
        //        return superClass.getRtType();
        //    }
        //}

        public sealed override RunTimeValueBase getValue(RunTimeScope scope, RunTimeDataHolder holder)
        {
            return scope.this_pointer;
        }

        public override string ToString()
        {
            return "super";
        }

    }
}
