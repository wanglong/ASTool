﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ASBinCode
{
    public sealed class Variable:VariableBase
    {
        public Variable(string name, int index, int refblockid) : this(name, index, false, refblockid, false)
        {

        }
        public Variable(string name, int index, int refblockid, bool isConst):this(name,index,false,refblockid,isConst)
        {

        }
        public Variable(string name, int index, bool ignoreImplicitCast, int refblockid)
            : this(name, index, ignoreImplicitCast, refblockid, RunTimeDataType.rt_void, false)

        {
        }
        public Variable(string name, int index, bool ignoreImplicitCast, int refblockid, bool isConst)
            :this(name,index,ignoreImplicitCast,refblockid, RunTimeDataType.rt_void,isConst)

        {
        }




        private Variable(string name, int index, bool ignoreImplicitCast, int refblockid, RunTimeDataType type, bool isConst)
            :base(name,index,ignoreImplicitCast,refblockid,type,isConst)
        { }

        /// <summary>
        /// 仅在编译优化阶段重设置成员索引。
        /// </summary>
        public void setIndexMemberWhenCompile(int newindex)
        {
            _indexOfMembers = newindex;
        }


        public sealed override RunTimeValueBase getValue(RunTimeScope scope,RunTimeDataHolder holder)
        {
            while (refblockid != scope.blockId)
            {
                scope = scope.parent;
            }
            return scope.memberData[indexOfMembers].getValue();
        }

        public sealed override SLOT getSlot(RunTimeScope scope, RunTimeDataHolder holder)
        {
            while (refblockid != scope.blockId)
            {
                scope = scope.parent;
            }
            return scope.memberData[indexOfMembers];
        }

        public sealed override SLOT getSlotForAssign(RunTimeScope scope, RunTimeDataHolder holder)
        {
            while (refblockid != scope.blockId)
            {
                scope = scope.parent;
            }
            return scope.memberData[indexOfMembers];
        }

        protected sealed override IMember _clone()
        {
            return new Variable(name, _indexOfMembers, ignoreImplicitCast, refblockid, valueType, isConst);
        }
    }
}
