﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASCompiler.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ASCompiler.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	/*
        ///	不要在这个类里编写属性访问器
        ///	*/
        ///
        ///	public class __buildin__
        ///	{
        ///		[native,__buildin__ismethod]
        ///		public static function _ismethod_(f:Function):Boolean;
        ///
        ///		[native,__buildin__trace]
        ///		public static function trace(...rest):void;
        ///
        ///		[native,__buildin__isnan]
        ///		public static function isNaN(value:Number):Boolean;
        ///
        ///		[native,__buildin__isfinite]
        ///		public static function isFinite(value:Number):Boolean;
        ///
        ///		[native,__buildin__parseint]
        ///		public static function parseInt(str:String=&quot;NaN&quot;, radix:uint = 0):Number;
        ///
        ///		[n [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string @__buildin__ {
            get {
                return ResourceManager.GetString("__buildin__", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	
        ///	public final class int extends Object
        ///	{
        ///		/**
        ///		 * 可表示的最大 32 位带符号整数为 2,147,483,647。
        ///		 * @langversion	3.0
        ///		 * @playerversion	Flash 9
        ///		 * @playerversion	Lite 4
        ///		 */
        ///		public static const MAX_VALUE : int = 2147483647;
        ///
        ///		/**
        ///		 * 可表示的最小 32 位带符号整数为 -2,147,483,648。
        ///		 * @langversion	3.0
        ///		 * @playerversion	Flash 9
        ///		 * @playerversion	Lite 4
        ///		 */
        ///		public static const MIN_VALUE : int = -2147483648;
        ///
        ///
        ///		[implicit_to]
        ///		private static function _to_int(thisObj:*):int{ return [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string _int {
            get {
                return ResourceManager.GetString("_int", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	/**
        ///	 * uint 类提供使用表示 32 位无符号整数的数据类型的方法。因为无符号整数只能为正，所以其最大值是 int 类最大值的两倍。
        ///	 * &lt;p class=&quot;- topic/p &quot;&gt;由 uint 类表示的值的范围介于 0 到 4,294,967,295 (2^32-1) 之间。&lt;/p&gt;&lt;p class=&quot;- topic/p &quot;&gt;可以通过声明 uint 类型的变量并为变量赋予文本值来创建 uint 对象。uint 类型变量的默认值为 &lt;codeph class=&quot;+ topic/ph pr-d/codeph &quot;&gt;0&lt;/codeph&gt;。&lt;/p&gt;&lt;p class=&quot;- topic/p &quot;&gt;uint 类主要用于像素颜色值（ARGB 和 RGBA）和 int 数据类型无法正常运行的其它情况。例如，数字 0xFFFFFFFF 表示 Alpha 值为 255 的白色颜色值，它无法用 int 数据类型表示，因为它不在有效的 int 值范围内。&lt;/p&gt;&lt;p class=&quot;- topic/p &quot;&gt;下例将创建一个 uint 对象并调用 &lt;codeph class=&quot;+ topic/ph  [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string _uint {
            get {
                return ResourceManager.GetString("_uint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	public dynamic class AneError extends Error
        ///	{
        ///		public function AneError (message:String=&quot;&quot;, id:int=0);
        ///	}
        ///} 的本地化字符串。
        /// </summary>
        internal static string AneError {
            get {
                return ResourceManager.GetString("AneError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	public dynamic class ArgumentError extends Error
        ///	{
        ///		public function ArgumentError (message:String=&quot;&quot;, id:int=0);
        ///	}
        ///} 的本地化字符串。
        /// </summary>
        internal static string ArgumentError {
            get {
                return ResourceManager.GetString("ArgumentError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	public dynamic class Array extends Object
        ///	{
        ///		/**
        ///		 * 指定 Array 类排序方法为不区分大小写的排序。您可以对 sort() 方法或 sortOn() 方法中的 options 参数使用此常数。 
        ///		 * 此常数的值为 1。
        ///		 * @langversion	3.0
        ///		 * @playerversion	Flash 9
        ///		 * @playerversion	Lite 4
        ///		 */
        ///		public static const CASEINSENSITIVE : uint = 1;
        ///
        ///		/**
        ///		 * 指定 Array 类排序方法为降序排序。您可以对 sort() 方法或 sortOn() 方法中的 options 参数使用此常数。 
        ///		 * 此常数的值为 2。
        ///		 * @langversion	3.0
        ///		 * @playerversion	Flash 9
        ///		 * @playerversion	Lite 4
        ///		 */
        ///		public static const DESC [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string Array {
            get {
                return ResourceManager.GetString("Array", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	public final class Boolean extends Object
        ///	{
        ///		
        ///		[implicit_to]
        ///		private static function _to_boolean(thisObj:*):Boolean{ return thisObj._v;}
        ///
        ///		[implicit_from]
        ///		private static function _from_value(value:Boolean):*{ return new Boolean(value); }
        ///
        ///		private var _v:Boolean;
        ///
        ///		public function Boolean (value:*=false){ _v=value ;}
        ///
        ///		[native,_boolean_toString]
        ///		public function toString () : String;
        ///
        ///		
        ///		public function valueOf () : Boolean{ return _v;}
        ///	}
        ///}
        /// 的本地化字符串。
        /// </summary>
        internal static string Boolean {
            get {
                return ResourceManager.GetString("Boolean", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	[_class_]
        ///	[no_constructor]
        ///	public dynamic class Class extends Object
        ///	{
        ///		
        ///		protected var _protoObj:*={};
        ///		
        ///
        ///		public function get prototype():*
        ///		{
        ///			return _protoObj;
        ///		}
        ///
        ///		
        ///
        ///
        ///		public function Class ();
        ///	}
        ///} 的本地化字符串。
        /// </summary>
        internal static string Class {
            get {
                return ResourceManager.GetString("Class", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	[hosted]
        ///	public final dynamic class Date extends Object
        ///	{
        ///		[native,_date_getdate]
        ///		public function get date () : Number;
        ///
        ///		public function set date (value:Number) : void{ setDate(value); }
        ///		
        ///		[native,_date_getutcdate]
        ///		public function get dateUTC () : Number;
        ///		public function set dateUTC (value:Number) : void { setUTCDate(value); }
        ///		
        ///		[native,_date_getday]
        ///		public function get day () : Number;
        ///		[native,_date_getutcday]
        ///		public function get dayUTC () : Number;
        ///		[na [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string Date {
            get {
                return ResourceManager.GetString("Date", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package flash.utils
        ///{
        ///	[_dictionary_]
        ///	public dynamic class Dictionary extends Object
        ///	{
        ///		public function Dictionary (weakKeys:Boolean=false);
        ///	}
        ///}
        /// 的本地化字符串。
        /// </summary>
        internal static string Dictionary {
            get {
                return ResourceManager.GetString("Dictionary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	[_error_class_]
        ///	public dynamic class Error extends Object
        ///	{
        ///		
        ///		public var message : String;
        ///
        ///		public var name : String;
        ///
        ///		private var _errorid:int;
        ///
        ///		private var _stacktrace:String;
        ///
        ///		public function get errorID () : int
        ///		{
        ///			return _errorid;
        ///		}
        ///
        ///		public function Error (message:String=&quot;&quot;, id:int=0)
        ///		{
        ///			name=&quot;Error&quot;;
        ///			this.message=message;
        ///			_errorid=id;
        ///			_stacktrace=_getstack();
        ///		}
        ///
        ///		//public static function getErrorMessage (index:int) : String;
        ///        /// [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	[_function_]
        ///	public final dynamic class Function extends Object
        ///	{
        ///		
        ///		
        ///		private var _func:Function;
        ///		private var _prototype:Object;
        ///
        ///		public function Function ()
        ///		{
        ///			_func=function():*{};
        ///			_prototype = {constructor:this};
        ///
        ///		}
        ///
        ///		public function toString():String
        ///		{
        ///			return &quot;function Function() {}&quot;;
        ///		}
        ///
        ///
        ///		[implicit_to]
        ///		private static function _to_function(thisObj:*):Function{ return thisObj._func;}
        ///
        ///		[implicit_from]
        ///		private static function _from_val [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string Function {
            get {
                return ResourceManager.GetString("Function", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package system.collections
        ///{
        ///	[_IEnumerable_]
        ///	public interface IEnumerable
        ///    {
        ///        function getEnumerator():IEnumerator;
        ///    }
        ///} 的本地化字符串。
        /// </summary>
        internal static string IEnumerable {
            get {
                return ResourceManager.GetString("IEnumerable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package system.collections
        ///{
        ///	[_IEnumerator_]
        ///	public interface IEnumerator
        ///    {
        ///        function get current():*;
        ///
        ///        function moveNext():Boolean;
        ///
        ///        function reset():void;
        ///    }
        ///}
        /// 的本地化字符串。
        /// </summary>
        internal static string IEnumerator {
            get {
                return ResourceManager.GetString("IEnumerator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	/**
        ///	 * Math 类包含表示常用数学函数和值的方法和常数。 
        ///	 * &lt;p class=&quot;- topic/p &quot;&gt;使用此类的方法和属性可以访问和处理数学常数和函数。Math 类的所有属性和方法都是静态的，而且必须使用 &lt;codeph class=&quot;+ topic/ph pr-d/codeph &quot;&gt;Math.method(&lt;/codeph&gt;&lt;codeph class=&quot;+ topic/ph pr-d/codeph &quot;&gt;&lt;i class=&quot;+ topic/ph hi-d/i &quot;&gt;parameter&lt;/i&gt;&lt;/codeph&gt;&lt;codeph class=&quot;+ topic/ph pr-d/codeph &quot;&gt;)&lt;/codeph&gt; 或 &lt;codeph class=&quot;+ topic/ph pr-d/codeph &quot;&gt;Math.constant&lt;/codeph&gt; 语法才能调用。在 ActionScript 中，使用双精度 IEEE-754 浮点数的最高精度定义常数。&lt;/p&gt;&lt;p class=&quot;- topic/p &quot;&gt;若干 Math 类方法使用以弧度为单位的角度测量值作为参数。在调用此方法之 [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string Math {
            get {
                return ResourceManager.GetString("Math", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	/**
        ///	 * 表示 IEEE-754 双精度浮点数的数据类型。使用与 Number 类关联的方法和属性可以操作基元数值。此类与 JavaScript 的 Number 类完全相同。
        ///	 * &lt;p class=&quot;- topic/p &quot;&gt;但 Number 类的属性是静态属性，这意味着无需对象就可以使用这些属性，因此您不需要使用构造函数。&lt;/p&gt;&lt;p class=&quot;- topic/p &quot;&gt;Number 数据类型符合双精度 IEEE-754 标准。 &lt;/p&gt;&lt;p class=&quot;- topic/p &quot;&gt;需要使用浮点值时，Number 数据类型很有用。Flash 运行时处理 int 和 uint 数据类型的效率高于处理 Number 数据类型的效率，但当所需值的范围超过 int 和 uint 数据类型的有效范围时，Number 数据类型很有用。Number 类可用于表示超出 int 和 uint 数据类型有效范围的整数值。Number 数据类型可使用多达 53 位来表示整数值，而 int 和 uint 则只能使用 32 位。Number 类型的变量的默认值为 &lt;codeph class=&quot; [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string Number {
            get {
                return ResourceManager.GetString("Number", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	[_object_]
        ///	public dynamic class Object
        ///	{
        ///		[native,_Object_toString]
        ///		private static var toString= function():String;
        ///		
        ///		private static var valueOf = function():*{ return this };
        ///
        ///		[native,_Object_hasOwnProperty]
        ///		private static var hasOwnProperty=function(name:String):Boolean;
        ///		
        ///		[native,_Object_isPrototypeOf]
        ///		private static var isPrototypeOf=function(V:*=null):Boolean;
        ///		
        ///		[native,_Object_propertyIsEnumerable]
        ///		private static var propertyIsEnumerable=function(name: [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string Object {
            get {
                return ResourceManager.GetString("Object", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /*
        ///&lt;E&gt; ::= &lt;T&gt;&lt;E1&gt; ;
        ///&lt;E1&gt;::= &quot;+&quot; &lt;T&gt; &lt;E1&gt; | null ;
        ///&lt;T&gt; ::= &lt;F&gt;&lt;T1&gt; ;
        ///&lt;T1&gt;::= &quot;*&quot; &lt;F&gt;&lt;T1&gt; |null;
        ///&lt;F&gt; ::=   identifier | number|&quot;(&quot; &lt;E&gt; &quot;)&quot;;
        ///*/
        ///
        ////*
        /////加上&quot;d&quot;即没有二义性
        ///&lt;S&gt; ::= &quot;i&quot;&lt;E&gt;&quot;t&quot;&lt;S&gt;&lt;S1&gt;&quot;d&quot;  | &quot;a&quot;;
        ///&lt;S1&gt; ::=&quot;e&quot;&lt;S&gt;|null;
        ///&lt;E&gt;  ::=&quot;b&quot;;
        ///*/
        ///
        ////*
        ///&lt;Stmts&gt; ::= &lt;Stmt&gt; &lt;StmtList&gt;;
        ///&lt;StmtList&gt; ::= &lt;Stmts&gt; | null;
        ///&lt;Stmt&gt; ::= &lt;Expression&gt; &lt;ExpEnd&gt;;
        ///&lt;ExpEnd&gt; ::= &quot;;&quot;|null;
        ///
        ///&lt;Expression&gt; ::= &lt;Multiply&gt; &lt;PlusOpt&gt;;
        ///&lt;PlusOpt&gt; ::= &quot;+&quot; &lt;Multiply&gt;&lt;PlusOpt&gt; | &quot;-&quot; &lt;Multiply&gt;&lt;PlusOpt&gt; | null;
        ///&lt;Multiply&gt; ::= &lt;Unit&gt; &lt;MultiplyOpt&gt;;
        ///&lt;Multip [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string PG1 {
            get {
                return ResourceManager.GetString("PG1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package	flash.display
        ///{
        ///	//临时用于可编译通过
        ///	public class Sprite
        ///	{
        ///		public function Sprite ();
        ///	}
        ///} 的本地化字符串。
        /// </summary>
        internal static string Sprite {
            get {
                return ResourceManager.GetString("Sprite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	
        ///	public final class String extends Object
        ///	{
        ///		private var _v:String;
        ///
        ///		[implicit_to]
        ///		private static function _to_string(thisObj:*):String{ return thisObj._v;}
        ///
        ///		[explicit_from]
        ///		private static function _explicit_from_value(value:*):*
        ///		{
        ///			if(value===undefined)
        ///			{
        ///				value=&quot;undefined&quot;;
        ///			}
        ///			else if(value==null)
        ///			{
        ///				value=&quot;null&quot;;
        ///			}
        ///
        ///			return new String(value); 
        ///		}
        ///
        ///		[implicit_from];
        ///		private static function _from_value(value:String):*
        ///		{		
        ///			 [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string String {
            get {
                return ResourceManager.GetString("String", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	public dynamic class TypeError extends Error
        ///	{
        ///		public function TypeError (message:String=&quot;&quot;, id:int=0);
        ///	}
        ///}
        /// 的本地化字符串。
        /// </summary>
        internal static string TypeError {
            get {
                return ResourceManager.GetString("TypeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	[imports]
        ///	[hosted]
        ///	public class Vector.&lt;T&gt;
        ///	{
        ///		private const t = T;
        ///
        ///		[native,_vector_constructor]
        ///		public function Vector.&lt;T&gt;(length:uint = 0, fixed:Boolean = false);
        ///
        ///		[native,_vector_getfixed]
        ///		public function get fixed() : Boolean;
        ///		[native,_vector_setfixed]
        ///		public function set fixed(value:Boolean):void;
        ///
        ///		[native,_vector_getlength]
        ///		public function get length():uint;
        ///		[native,_vector_setlength]
        ///    		public function set length(value:uint):void;
        ///
        ///		public function toString():S [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string Vector {
            get {
                return ResourceManager.GetString("Vector", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 package
        ///{
        ///	import system.collections.IEnumerator
        ///	[no_constructor]
        ///	[_YieldIterator_]
        ///	public final class YieldIterator implements IEnumerator
        ///	{
        ///		[native,_yield_current]
        ///		public function get current():*;
        ///
        ///		[native,_yield_movenext]
        ///        public function moveNext():Boolean;
        ///
        ///        public function reset():void;
        ///		
        ///	}
        ///} 的本地化字符串。
        /// </summary>
        internal static string YieldIterator {
            get {
                return ResourceManager.GetString("YieldIterator", resourceCulture);
            }
        }
    }
}
