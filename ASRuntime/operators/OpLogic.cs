﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ASRuntime.operators
{
    class OpLogic
    {
        public static void execNOT(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {
            var v = TypeConverter.ConvertToBoolean(step.arg1.getValue(scope),player,step.token);

            if (object.ReferenceEquals(v, ASBinCode.rtData.rtBoolean.True))
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False );
            }
            else
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
            }
        }


        public static void execGT_NUM(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {
            
            
            ASBinCode.rtData.rtNumber a1 = (ASBinCode.rtData.rtNumber)step.arg1.getValue(scope);
            ASBinCode.rtData.rtNumber a2 = (ASBinCode.rtData.rtNumber)step.arg2.getValue(scope);

            if (a1.value > a2.value)
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
            }
            else
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
            }

            
            //step.reg.setValue(new ASBinCode.rtData.rtNumber(a1.value + a2.value), eaxs, scope);
        }

        public static void execGE_NUM(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {


            ASBinCode.rtData.rtNumber a1 = (ASBinCode.rtData.rtNumber)step.arg1.getValue(scope);
            ASBinCode.rtData.rtNumber a2 = (ASBinCode.rtData.rtNumber)step.arg2.getValue(scope);

            if (a1.value >= a2.value)
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
            }
            else
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
            }


            //step.reg.setValue(new ASBinCode.rtData.rtNumber(a1.value + a2.value), eaxs, scope);
        }

        public static void execGT_Void(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {
            ASBinCode.IRunTimeValue v1 = step.arg1.getValue(scope);
            ASBinCode.IRunTimeValue v2 = step.arg2.getValue(scope);

            if (
                (
                v1.rtType == ASBinCode.RunTimeDataType.rt_string
                &&
                (v2.rtType == ASBinCode.RunTimeDataType.rt_string || v2.rtType == ASBinCode.RunTimeDataType.rt_null)
                )
                ||
                v2.rtType == ASBinCode.RunTimeDataType.rt_string
                &&
                (v1.rtType == ASBinCode.RunTimeDataType.rt_string || v1.rtType == ASBinCode.RunTimeDataType.rt_null)
                )
            {
                string s1 = TypeConverter.ConvertToString(step.arg1.getValue(scope), player, step.token);
                string s2 = TypeConverter.ConvertToString(step.arg2.getValue(scope), player, step.token);

                if (s1 == null || s2 == null)
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
                }
                else if (string.CompareOrdinal(s1, s2) > 0)
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
                }
                else
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
                }

            }
            else
            {
                double n1 = TypeConverter.ConvertToNumber(v1,player,step.token);
                double n2 = TypeConverter.ConvertToNumber(v2, player, step.token);

                if (n1 > n2)
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
                }
                else
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
                }
            }
        }

        public static void execGE_Void(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {
            ASBinCode.IRunTimeValue v1 = step.arg1.getValue(scope);
            ASBinCode.IRunTimeValue v2 = step.arg2.getValue(scope);

            if (
                (
                v1.rtType == ASBinCode.RunTimeDataType.rt_string
                &&
                (v2.rtType == ASBinCode.RunTimeDataType.rt_string || v2.rtType == ASBinCode.RunTimeDataType.rt_null)
                )
                ||
                v2.rtType == ASBinCode.RunTimeDataType.rt_string
                &&
                (v1.rtType == ASBinCode.RunTimeDataType.rt_string || v1.rtType == ASBinCode.RunTimeDataType.rt_null)
                )
            {
                string s1 = TypeConverter.ConvertToString(step.arg1.getValue(scope), player, step.token);
                string s2 = TypeConverter.ConvertToString(step.arg2.getValue(scope), player, step.token);

                if (s1 == null || s2 == null)
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
                }
                else if (string.CompareOrdinal(s1, s2) >= 0)
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
                }
                else
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
                }

            }
            else
            {
                double n1 = TypeConverter.ConvertToNumber(v1, player, step.token);
                double n2 = TypeConverter.ConvertToNumber(v2, player, step.token);

                if (n1 >= n2)
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
                }
                else
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
                }
            }
        }

        public static void execLT_NUM(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {


            ASBinCode.rtData.rtNumber a1 = (ASBinCode.rtData.rtNumber)step.arg1.getValue(scope);
            ASBinCode.rtData.rtNumber a2 = (ASBinCode.rtData.rtNumber)step.arg2.getValue(scope);

            if (a1.value < a2.value)
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
            }
            else
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
            }


            //step.reg.setValue(new ASBinCode.rtData.rtNumber(a1.value + a2.value), eaxs, scope);
        }

        public static void execLE_NUM(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {


            ASBinCode.rtData.rtNumber a1 = (ASBinCode.rtData.rtNumber)step.arg1.getValue(scope);
            ASBinCode.rtData.rtNumber a2 = (ASBinCode.rtData.rtNumber)step.arg2.getValue(scope);

            if (a1.value <= a2.value)
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
            }
            else
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
            }
            
        }

        public static void execLT_VOID(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {
            ASBinCode.IRunTimeValue v1 = step.arg1.getValue(scope);
            ASBinCode.IRunTimeValue v2 = step.arg2.getValue(scope);

            if (
                (
                v1.rtType == ASBinCode.RunTimeDataType.rt_string
                &&
                (v2.rtType == ASBinCode.RunTimeDataType.rt_string || v2.rtType == ASBinCode.RunTimeDataType.rt_null)
                )
                ||
                v2.rtType == ASBinCode.RunTimeDataType.rt_string
                &&
                (v1.rtType == ASBinCode.RunTimeDataType.rt_string || v1.rtType == ASBinCode.RunTimeDataType.rt_null)
                )
            {
                string s1 = TypeConverter.ConvertToString(step.arg1.getValue(scope), player, step.token);
                string s2 = TypeConverter.ConvertToString(step.arg2.getValue(scope), player, step.token);

                if (s1 == null || s2 == null)
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
                }
                else if (string.CompareOrdinal(s1, s2) < 0)
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
                }
                else
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
                }
            }
            else
            {
                double n1 = TypeConverter.ConvertToNumber(v1, player, step.token);
                double n2 = TypeConverter.ConvertToNumber(v2, player, step.token);

                if (n1 < n2)
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
                }
                else
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
                }
            }
        }

        public static void execLE_VOID(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {
            ASBinCode.IRunTimeValue v1 = step.arg1.getValue(scope);
            ASBinCode.IRunTimeValue v2 = step.arg2.getValue(scope);

            if (
                (
                v1.rtType == ASBinCode.RunTimeDataType.rt_string
                &&
                (v2.rtType == ASBinCode.RunTimeDataType.rt_string || v2.rtType == ASBinCode.RunTimeDataType.rt_null)
                )
                ||
                v2.rtType == ASBinCode.RunTimeDataType.rt_string
                &&
                (v1.rtType == ASBinCode.RunTimeDataType.rt_string || v1.rtType == ASBinCode.RunTimeDataType.rt_null)
                )
            {
                string s1 = TypeConverter.ConvertToString(step.arg1.getValue(scope), player, step.token);
                string s2 = TypeConverter.ConvertToString(step.arg2.getValue(scope), player, step.token);

                if (s1 == null || s2 == null)
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
                }
                else if (string.CompareOrdinal(s1, s2) <= 0)
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
                }
                else
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
                }
            }
            else
            {
                double n1 = TypeConverter.ConvertToNumber(v1, player, step.token);
                double n2 = TypeConverter.ConvertToNumber(v2, player, step.token);

                if (n1 <= n2)
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
                }
                else
                {
                    step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
                }
            }
        }

        public static void execEQ(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {
            if (testEquals(step.arg1.getValue(scope), step.arg2.getValue(scope), player, step, scope))
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
            }
            else
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False );
            }
        }

        public static void execNotEQ(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {
            if (!testEquals(step.arg1.getValue(scope), step.arg2.getValue(scope), player, step, scope))
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
            }
            else
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
            }
        }

        public static void execEQ_NumNum(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {
            var n1 = TypeConverter.ConvertToNumber(step.arg1.getValue(scope), player, step.token);
            var n2 = TypeConverter.ConvertToNumber(step.arg2.getValue(scope), player, step.token);

            if (n1==n2)
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
            }
            else
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
            }
        }

        public static void execNotEQ_NumNum(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {
            var n1 = TypeConverter.ConvertToNumber(step.arg1.getValue(scope), player, step.token);
            var n2 = TypeConverter.ConvertToNumber(step.arg2.getValue(scope), player, step.token);

            if (n1 != n2)
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
            }
            else
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
            }
        }

        public static void execEQ_StrStr(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {
            var n1 = TypeConverter.ConvertToString(step.arg1.getValue(scope), player, step.token);
            var n2 = TypeConverter.ConvertToString(step.arg2.getValue(scope), player, step.token);

            if (string.CompareOrdinal(n1,n2)==0)
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
            }
            else
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
            }
        }

        public static void execNotEQ_StrStr(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {
            var n1 = TypeConverter.ConvertToString(step.arg1.getValue(scope), player, step.token);
            var n2 = TypeConverter.ConvertToString(step.arg2.getValue(scope), player, step.token);

            if (string.CompareOrdinal(n1, n2) != 0)
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
            }
            else
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
            }
        }

        private static bool  _execStrictEQ(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {
            //strict equality 运算符仅针对数字类型（Number、int 和 uint）执行自动数据转换
            ASBinCode.IRunTimeValue v1 = step.arg1.getValue(scope);
            ASBinCode.IRunTimeValue v2 = step.arg2.getValue(scope);

            if ((
                v1.rtType == ASBinCode.RunTimeDataType.rt_number || v1.rtType == ASBinCode.RunTimeDataType.rt_int
                ||
                v1.rtType == ASBinCode.RunTimeDataType.rt_uint
                )

                &&
                (
                v2.rtType == ASBinCode.RunTimeDataType.rt_number || v2.rtType == ASBinCode.RunTimeDataType.rt_int
                ||
                v2.rtType == ASBinCode.RunTimeDataType.rt_uint
                )
                )
            {
                double n1 = TypeConverter.ConvertToNumber(v1, player, step.token);
                double n2 = TypeConverter.ConvertToNumber(v2, player, step.token);

                if (n1 == n2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (v1.rtType == ASBinCode.RunTimeDataType.rt_string && v2.rtType == ASBinCode.RunTimeDataType.rt_string)
            {
                string s1 = TypeConverter.ConvertToString(step.arg1.getValue(scope), player, step.token);
                string s2 = TypeConverter.ConvertToString(step.arg2.getValue(scope), player, step.token);
                if (string.CompareOrdinal(s1, s2) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (object.ReferenceEquals(v1, v2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public static void execStrictEQ(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {
            if (_execStrictEQ(player, step, scope))
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
            }
            else
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
            }
        }
        public static void execStrictNotEQ(Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {
            if (!_execStrictEQ(player, step, scope))
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.True);
            }
            else
            {
                step.reg.getISlot(scope).setValue(ASBinCode.rtData.rtBoolean.False);
            }
        }

        /// <summary>
        ///测试两个表达式是否相等。如果表达式相等，则结果为 true。 
        ///如果两个操作数的数据类型相匹配，则相等的定义取决于操作数的数据类型：
        ///如果 int、uint 和 Boolean 类型具有相同的值，则将其值视为相等。
        ///值相匹配的两个 Number 被视为相等，除非两个值都为 NaN。
        ///如果两个操作数的值均为 null 或 undefined，则将它们视为相等。
        ///如果字符串表达式具有相同的字符数，而且这些字符都相同，则这些字符串表达式相等。
        ///对于 XML 对象： 
        ///如果一个操作数是文本或属性节点，而另一个操作数具有简单的内容，则使用 toString() 方法可将两个操作数转换为字符串，如果生成的字符串相匹配，则将这两个操作数视为相等。 
        ///否则，仅当两个对象的限定名、特性和子属性都匹配时，才会被视为相等。
        ///如果 XMLList 对象具有相同数目的属性，并且属性的顺序和值都匹配，则可将其视为相等。
        ///对于 Namespace 对象，如果两个对象的 uri 属性相匹配，则其值被视为相等。
        ///对于 QName 对象，如果两个对象的 uri 属性相匹配，并且两个对象的 localName 属性也相匹配，则其值视为相等。
        ///表示对象、数组和函数的变量按引用进行比较。如果两个这样的变量引用同一个对象、数组或函数，则它们相等。而两个单独的数组即使具有相同数量的元素，也永远不会被视为相等。
        ///如果这两个操作数的数据类型不匹配，则结果为 false，但在以下情况下除外： 
        ///操作数的值为 undefined 和 null，在这种情况下结果为 true。
        ///自动数据类型转换将数据类型为 String、Boolean、int、uint 和 Number 的值转换为兼容的类型，并且转换后的值相等，在这种情况下，操作数被视为相等。
        ///一个操作数的类型为 XML，并且包含简单内容(hasSimpleContent() == true)，在使用 toString() 将这两个操作数均转换为字符串后，所生成的字符串相匹配。
        ///一个操作数的类型为 XMLList，并且满足以下任一条件： 
        ///XMLList 对象的 length 属性是 0，而另一个对象为 undefined。
        ///XMLList 对象的 length 属性为 1，XMLList 对象的一个元素与另一个操作数相匹配。
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool testEquals(ASBinCode.IRunTimeValue v1,ASBinCode.IRunTimeValue v2, Player player, ASBinCode.OpStep step, ASBinCode.IRunTimeScope scope)
        {
            ASBinCode.RunTimeDataType t1 = v1.rtType;
            ASBinCode.RunTimeDataType t2 = v2.rtType;

            if (
                (
                t1 == ASBinCode.RunTimeDataType.rt_int
                || t1 == ASBinCode.RunTimeDataType.rt_uint || t1 == ASBinCode.RunTimeDataType.rt_boolean
                || t1 == ASBinCode.RunTimeDataType.rt_number
                )
                &&
                (t2 == ASBinCode.RunTimeDataType.rt_int
                || t2 == ASBinCode.RunTimeDataType.rt_uint || t2 == ASBinCode.RunTimeDataType.rt_boolean
                || t2 == ASBinCode.RunTimeDataType.rt_number
                )
                )
            {
                return TypeConverter.ConvertToNumber(v1, player, step.token) == TypeConverter.ConvertToNumber(v2, player, step.token);
            }
            else if (
                (t1 == ASBinCode.RunTimeDataType.rt_null || t1 == ASBinCode.RunTimeDataType.rt_void)
                &&
                (t2 == ASBinCode.RunTimeDataType.rt_null || t2 == ASBinCode.RunTimeDataType.rt_void)
                )
            {
                return true;
            }
            else if (t1 == ASBinCode.RunTimeDataType.rt_string && t2 == ASBinCode.RunTimeDataType.rt_string)
            {
                return string.CompareOrdinal(TypeConverter.ConvertToString(v1, player, step.token)
                    ,
                    TypeConverter.ConvertToString(v2, player, step.token)
                    ) == 0;
            }
            else if (t1 == ASBinCode.RunTimeDataType.rt_string)
            {
                switch (t2)
                {
                    case ASBinCode.RunTimeDataType.rt_boolean:
                        if (v2.Equals(ASBinCode.rtData.rtBoolean.True))
                        {
                            return TypeConverter.ConvertToInt(v1, player, step.token) == 1;
                        }
                        else
                        {
                            return TypeConverter.ConvertToInt(v1, player, step.token) != 1;
                        }
                    case ASBinCode.RunTimeDataType.rt_int:
                        return TypeConverter.ConvertToInt(v1, player, step.token) == TypeConverter.ConvertToInt(v2, player, step.token);
                    case ASBinCode.RunTimeDataType.rt_uint:
                        return TypeConverter.ConvertToUInt(v1, player, step.token) == TypeConverter.ConvertToUInt(v2, player, step.token);
                    case ASBinCode.RunTimeDataType.rt_number:
                        return TypeConverter.ConvertToNumber(v1, player, step.token) == TypeConverter.ConvertToNumber(v2, player, step.token);
                    case ASBinCode.RunTimeDataType.rt_string:
                        return string.CompareOrdinal(
                            TypeConverter.ConvertToString(v1, player, step.token)
                            ,
                            TypeConverter.ConvertToString(v2, player, step.token)
                            ) == 0;
                    case ASBinCode.RunTimeDataType.rt_void:
                        return false;
                    case ASBinCode.RunTimeDataType.rt_null:
                        return false;
                    case ASBinCode.RunTimeDataType.unknown:
                        return false;
                    default:
                        break;
                }
            }
            else if (t2 == ASBinCode.RunTimeDataType.rt_string)
            {
                switch (t1)
                {
                    case ASBinCode.RunTimeDataType.rt_boolean:
                        if (v1.Equals(ASBinCode.rtData.rtBoolean.True))
                        {
                            return TypeConverter.ConvertToInt(v2, player, step.token) == 1;
                        }
                        else
                        {
                            return TypeConverter.ConvertToInt(v2, player, step.token) != 1;
                        }
                    case ASBinCode.RunTimeDataType.rt_int:
                        return TypeConverter.ConvertToInt(v1, player, step.token) == TypeConverter.ConvertToInt(v2, player, step.token);
                    case ASBinCode.RunTimeDataType.rt_uint:
                        return TypeConverter.ConvertToUInt(v1, player, step.token) == TypeConverter.ConvertToUInt(v2, player, step.token);
                    case ASBinCode.RunTimeDataType.rt_number:
                        return TypeConverter.ConvertToNumber(v1, player, step.token) == TypeConverter.ConvertToNumber(v2, player, step.token);
                    case ASBinCode.RunTimeDataType.rt_string:
                        return string.CompareOrdinal(
                            TypeConverter.ConvertToString(v1, player, step.token)
                            ,
                            TypeConverter.ConvertToString(v2, player, step.token)
                            ) == 0;
                    case ASBinCode.RunTimeDataType.rt_void:
                        return false;
                    case ASBinCode.RunTimeDataType.rt_null:
                        return false;
                    case ASBinCode.RunTimeDataType.unknown:
                        return false;
                    default:
                        break;
                }
            }

            return false;
        }


    }
}