package system 
{
	import system.arrays.Array_Of_String;
	[struct]
	[link_system]
	public final class DateTime extends _Object_ 
	{
		[native, _system_DateTime_static_MaxValue_getter]
		public static const MaxValue:DateTime;
		[native, _system_DateTime_static_MinValue_getter]
		public static const MinValue:DateTime;
		
		[creator];
		[native, _system_DateTime_creator__];
		private static function _creator(type:Class):*;
		
		
		[native,_system_DateTime_static_constructor_]
		public static function constructor_(year:int,month:int,day:int):DateTime;
		
		[native,_system_DateTime_static_constructor__]
		public static function constructor__(year:int,month:int,day:int,hour:int,minute:int,second:int):DateTime;
		
		[native,_system_DateTime_static_constructor___]
		public static function constructor___(year:int,month:int,day:int,hour:int,minute:int,second:int,kind:DateTimeKind):DateTime;
		
		[native,_system_DateTime_static_constructor____]
		public static function constructor____(year:int,month:int,day:int,hour:int,minute:int,second:int,millsecond:int):DateTime;
		
		[native,_system_DateTime_static_constructor_____]
		public static function constructor_____(year:int,month:int,day:int,hour:int,minute:int,second:int,millsecond:int,kind:DateTimeKind):DateTime;
		
		
		[native,_system_DateTime_static_constructor______]
		public static function constructor______(ticks:Int64):DateTime;
		
		[native,_system_DateTime_static_constructor_______]
		public static function constructor_______(ticks:Int64,kind:DateTimeKind):DateTime;
		
		
		[native,_system_DateTime_now]
		public static function get now():DateTime;
		
		[native,_system_DateTime_toDay]
		public static function get toDay():DateTime;
		
		[native,_system_DateTime_utcNow]
		public static function get utcNow():DateTime;
		
		[native,_system_DateTime_static_compare]
		public static function compare(t1:DateTime,t2:DateTime):int;
		
		[native,_system_DateTime_static_daysInMonth]
		public static function daysInMonth(year:int,month:int):int;
		
		
		[native,_system_DateTime_ctor]
		public function DateTime();
		
		
		[native,_system_DateTime_date]
		public function get date():DateTime;
		
		
		[native,_system_DateTime_day]
		public function get day():int;
		
		[native,_system_DateTime_dayOfWeek]
		public function get dayOfWeek():DayOfWeek;
		
		[native,_system_DateTime_dayOfYear]
		public function get dayOfYear():int;
		
		
		[native,_system_DateTime_hour]
		public function get hour():int;
		
		[native,_system_DateTime_kind]
		public function get kind():DateTimeKind;
		
		[native,_system_DateTime_millsecond]
		public function get millsecond():int;
		
		[native,_system_DateTime_minute]
		public function get minute():int;
		
		[native,_system_DateTime_month]
		public function get month():int;
		
		
		[native,_system_DateTime_second]
		public function get second():int;
		
		
		[native,_system_DateTime_ticks]
		public function get ticks():Int64;
		
		
		[native,_system_DateTime_timeOfDay]
		public function get timeOfDay():TimeSpan;
		
		[native,_system_DateTime_year]
		public function get year():int;
		
		
		[native,_system_DateTime_add]
		public function add(value:TimeSpan):DateTime;
		
		[native,_system_DateTime_addDays]
		public function addDays(value:Number):DateTime;
		
		[native,_system_DateTime_addHours]
		public function addHours(value:Number):DateTime;
		
		[native,_system_DateTime_addMilliseconds]
		public function addMilliseconds(value:Number):DateTime;
		
		[native,_system_DateTime_addMinutes]
		public function addMinutes(value:Number):DateTime;
		
		[native,_system_DateTime_addMonths]
		public function addMonths(value:int):DateTime;
		
		[native,_system_DateTime_addSeconds]
		public function addSeconds(value:Number):DateTime;
		
		[native,_system_DateTime_addTicks]
		public function addTicks(value:Int64):DateTime;
		
		[native,_system_DateTime_addYears]
		public function addYears(value:int):DateTime;
		
		[native,_system_DateTime_getDateTimeFormats]
		public function getDateTimeFormats():Array_Of_String;
		
		[native,_system_DateTime_subtract]
		public function subtract(value:DateTime):TimeSpan;
		
		[native,_system_DateTime_subtract_TimeSpan]
		public function subtract_TimeSpan(value:TimeSpan):DateTime;
		

		[native,_system_DateTime_compareTo]
		public function compareTo(value:_Object_):int;
		
		[native,_system_DateTime_compareTo_DateTime]
		public function compareTo_DateTime(value:DateTime):int;
		
	}

}