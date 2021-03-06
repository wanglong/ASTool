﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ASBinCode
{
    /// <summary>
    /// 操作符
    /// </summary>
    public enum OpCode : byte
    {
        /// <summary>
        /// 类型转换
        /// </summary>
        cast=0,
        /// <summary>
        /// 赋值 =
        /// </summary>
        assigning=1,

        /// <summary>
        /// 加法+
        /// </summary>
        add =2,
        add_number=3,
        add_string=4,

        /// <summary>
        /// 减法-
        /// </summary>
        sub =5,
        sub_number=6,
        /// <summary>
        /// 乘法 *
        /// </summary>
        multi=7,
        /// <summary>
        /// 除法 /
        /// </summary>
        div=8,
        /// <summary>
        /// 求模 %
        /// </summary>
        mod=9,

        /// <summary>
        /// 取反-
        /// </summary>
        neg =10,
        /// <summary>
        /// 大于 >
        /// 比较两个表达式，确定 expression1 是否大于 expression2；如果是，则结果为 true。
        /// 如果 expression1 小于等于 expression2，则结果为 false。 
        ///如果两个操作数的类型都为 String，则使用字母顺序比较操作数；所有大写字母都排在小写字母的前面。
        ///否则，首先将操作数转换为数字，然后进行比较。
        /// </summary>
        gt_num = 11,
        /// <summary>
        /// 动态 >
        /// </summary>
        gt_void =12,
        /// <summary>
        /// 小于 &lt;
        /// </summary>
        lt_num=13,
        /// <summary>
        /// 动态 &lt;
        /// </summary>
        lt_void =14,
        /// <summary>
        /// 大于等于 >=
        /// </summary>
        ge_num =15,
        /// <summary>
        /// 动态>=
        /// </summary>
        ge_void=16,

        /// <summary>
        /// 小于等于 &lt;=
        /// </summary>
        le_num =17,
        /// <summary>
        /// 动态 &lt;=
        /// </summary>
        le_void=18,
        /// <summary>
        /// 等于=
        /// </summary>
        equality =19,
        /// <summary>
        /// 数字之间比较
        /// </summary>
        equality_num_num=20,
        /// <summary>
        /// 字符串间比较
        /// </summary>
        equality_str_str=21,

        not_equality=22,
        not_equality_num_num=23,
        not_equality_str_str=24,

        /// <summary>
        /// === 测试两个表达式是否相等，但不执行自动数据转换。如果两个表达式（包括它们的数据类型）相等，则结果为 true。 
        /// </summary>
        strict_equality = 25,

        not_strict_equality=26,

        /// <summary>
        /// ! 逻辑取反
        /// </summary>
        logic_not=27,

        /// <summary>
        /// 位与 &
        /// </summary>
        bitAnd =28,
        /// <summary>
        /// 位或 |
        /// </summary>
        bitOr =29,

        /// <summary>
        /// 按位求补 ~
        /// </summary>
        bitNot =30,

        /// <summary>
        /// 位异或 ^
        /// </summary>
        bitXOR =31,
        /// <summary>
        /// 左移位 &lt;&lt;
        /// </summary>
        bitLeftShift=32,
        /// <summary>
        /// 右移位 >>
        /// </summary>
        bitRightShift=33,
        /// <summary>
        /// 结果为无符号32位整数右移位
        /// </summary>
        bitUnsignedRightShift=34,

        /// <summary>
        /// ++ 前缀
        /// </summary>
        increment =35,
        /// <summary>
        /// -- 前缀
        /// </summary>
        decrement =36,

        increment_int=37,
        increment_uint=38,
        increment_number=39,

        decrement_int=40,
        decrement_uint=41,
        decrement_number=42,

        /// <summary>
        /// ++ 后缀
        /// </summary>
        suffix_inc =43,

        suffix_inc_int=44,
        suffix_inc_uint=45,
        suffix_inc_number=46,

        /// <summary>
        /// -- 后缀
        /// </summary>
        suffix_dec =47,

        suffix_dec_int=48,
        suffix_dec_uint=49,
        suffix_dec_number=50,

        /// <summary>
        /// 条件跳转
        /// </summary>
        if_jmp=51,
        /// <summary>
        /// 无条件跳转
        /// </summary>
        jmp=52,

        /// <summary>
        /// 标签行
        /// </summary>
        flag=53,

        

        /// <summary>
        /// 抛出异常
        /// </summary>
        raise_error=54,
        /// <summary>
        /// 捕获异常
        /// </summary>
        catch_error=55,
        /// <summary>
        /// 进入try
        /// </summary>
        enter_try=56,
        /// <summary>
        /// 退出try
        /// </summary>
        quit_try=57,
        /// <summary>
        /// 进入catch
        /// </summary>
        enter_catch=58,
        /// <summary>
        /// 退出catch
        /// </summary>
        quit_catch=59,
        /// <summary>
        /// 进入finally
        /// </summary>
        enter_finally=60,
        /// <summary>
        /// 退出finally
        /// </summary>
        quit_finally=61,


        /// <summary>
        /// 内置trace语句
        /// </summary>
        native_trace = 62,

        /// <summary>
        /// function绑定上下文
        /// </summary>
        bind_scope =63,
        

        /// <summary>
        /// 创建函数参数上下文
        /// </summary>
        make_para_scope =64,
        /// <summary>
        /// 复制参数
        /// </summary>
        push_parameter =65,

        /// <summary>
        /// 调 function
        /// </summary>
        call_function = 66,
        /// <summary>
        /// return
        /// </summary>
        function_return=67,

        /// <summary>
        /// 创建类的实例
        /// </summary>
        new_instance=68,
        /// <summary>
        /// 从class创建类的实例
        /// </summary>
        new_instance_class =69,
        /// <summary>
        /// 初始化静态类对象
        /// </summary>
        init_staticclass=70,
        /// <summary>
        /// 准备构造函数参数
        /// </summary>
        prepare_constructor_argement=71,
        /// <summary>
        /// 准备从class中创建类的构造函数
        /// </summary>
        prepare_constructor_class_argement = 72,
        /// <summary>
        /// 加class构造函数参数
        /// </summary>
        push_parameter_class=73,
        /// <summary>
        /// 访问对象成员
        /// </summary>
        access_dot =74,

        access_dot_byname=75,

        /// <summary>
        /// []访问 需动态检查类型
        /// </summary>
        bracket_access =76,

        /// <summary>
        /// 访问方法
        /// </summary>
        access_method =77,

        /// <summary>
        /// 如果不是method,则清空this指针
        /// </summary>
        clear_thispointer=78,

        /// <summary>
        /// 如果是一个属性，则尝试从属性中读取值。
        /// </summary>
        try_read_getter=79,

        /// <summary>
        /// 试图往属性中写回值
        /// </summary>
        try_write_setter=80,

        /// <summary>
        /// 删除属性
        /// </summary>
        delete_prop=81,

        /// <summary>
        /// 设置动态属性
        /// </summary>
        set_dynamic_prop=82,

        /// <summary>
        /// 从对象转换到基本类型
        /// </summary>
        cast_primitive=83,


        array_create=84,
        /// <summary>
        /// 往原始数组对象中追加元素
        /// </summary>
        array_push=85,

        ///// <summary>
        ///// 初始化Vector
        ///// </summary>
        //init_vector =85,

        
        /// <summary>
        /// 绑定Vector访问器
        /// </summary>
        vectorAccessor_bind=86,
        /// <summary>
        /// 先转换索引，再绑定Vector访问器
        /// </summary>
        vectorAccessor_convertidx=87,

        /// <summary>
        /// 往vector里追加元素
        /// </summary>
        vector_push=88,
        /// <summary>
        /// 把数组的内容拷贝到Vector
        /// </summary>
        vector_pusharray=89,
        /// <summary>
        /// 把Vector的内容拷贝到Vector
        /// </summary>
        vector_pushvector = 90,

        /// <summary>
        /// 从初始数据中构造Vector
        /// 要么是数组，要么是完全匹配的Vector,要么是T要创建的Vector的T的子类的Vector
        /// </summary>
        vector_initfrmdata=91,

        /// <summary>
        /// 链接到包外成员
        /// </summary>
        link_outpackagevairable=92,

        /// <summary>
        /// 标记准备调父类的构造函数
        /// </summary>
        flag_call_super_constructor =93,


        /// <summary>
        /// 获取forin的enumerator
        /// </summary>
        forin_get_enumerator=94,
        /// <summary>
        /// 获取foreach的enumerator
        /// </summary>
        foreach_get_enumerator=95,
        /// <summary>
        /// 调movenext
        /// </summary>
        enumerator_movenext=96,

        /// <summary>
        /// 调用读取当前值
        /// </summary>
        enumerator_current=97,

        /// <summary>
        /// 关闭枚举器
        /// </summary>
        enumerator_close = 98,

        /// <summary>
        /// is运算符
        /// </summary>
        logic_is=99,
        /// <summary>
        /// instanceof运算符
        /// </summary>
        logic_instanceof=100,

        /// <summary>
        /// as运算符
        /// </summary>
        convert_as=101,

        /// <summary>
        /// in运算符
        /// </summary>
        logic_in =102,

        /// <summary>
        /// typeof运算符
        /// </summary>
        unary_typeof=103,

        /// <summary>
        /// 乘法 2个数字
        /// </summary>
        multi_number =104,

        div_number=105,

        mod_number=106,

        unary_plus=107,

        function_create=108,

        yield_return=109,

        yield_break=110,

        yield_continuetoline=111,

    }
}
