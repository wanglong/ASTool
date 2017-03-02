﻿using ASBinCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASRuntime
{
    class RunTimeScope : IRunTimeScope
    {
        HeapSlot[] memberDataList;

        private IList<ISLOT> runtimestack;
        private int _offset;
        private int _blockid;
        public RunTimeScope(
            //IList<IMember> members,
            HeapSlot[] memberDataList,
            IList<ISLOT> rtStack,
            int offset, int blockid,
            IRunTimeScope parent
            )
        {
            runtimestack = rtStack;
            this._offset = offset;
            _blockid = blockid;
            _parent = parent;

            this.memberDataList = memberDataList;
            

        }



        public ISLOT[] memberData
        {
            get
            {
                return memberDataList;
            }
        }

        public int offset
        {
            get
            {
                return _offset;
            }
        }

        private IRunTimeScope _parent;
        public IRunTimeScope parent
        {
            get
            {
                return _parent;
            }
        }

        public IList<ISLOT> stack
        {
            get
            {
                return runtimestack;
            }
        }

        public int blockId
        {
            get
            {
                return _blockid;
            }
        }
    }
}