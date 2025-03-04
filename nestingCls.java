class supclass{
	private int a = 50;
	class subclass{
		void show(){
			supclass obj = new person();
			System.out.println(obj.a);
		}
	}
}
class nestingCls{
	public static void main(String[] args){
		sup obj = new supclass();
		supclass.subclass object = obj.new subclass();
		object.show();
	}
}