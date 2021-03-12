using System;
					
public class Program
{
	public struct timenprice{
		public bool modeIstime;
		public double t;
		public double p;
	}
	public timenprice price_time_return(bool Istime ,double t,double p){
		timenprice tnp;
		if(Istime){
		tnp.modeIstime = true;
		tnp.t = t;
		tnp.p = Math.Pow(t+1,2);
		}else
		{
		tnp.modeIstime = false;
		tnp.t =Math.Sqrt(t+1);
		tnp.p = p;
		if(tnp.t<0){
			Console.WriteLine("invalid mouse position");
			throw new Exception("invalid mouse position");
		}
		}
		Console.WriteLine(""+tnp.t.ToString("F2")+","+""+tnp.p.ToString("F2"));
		return tnp;
	}
	public void Main()
	{
		string getkeyboardvalue;
		double x,y;	
		Console.WriteLine("Input mode");
   		getkeyboardvalue = Console.ReadLine();
		Console.WriteLine("Input time");
		x = double.Parse(Console.ReadLine());
		Console.WriteLine("Input price");
		y = double.Parse(Console.ReadLine());
		
		if(getkeyboardvalue =="time"){
			 price_time_return(true,x,y);
		}else if(getkeyboardvalue =="price"){
			price_time_return(false,x,y);
		}
		else {
			Console.WriteLine("invalid mode");
			throw new Exception("invalid mode");
		}
	}
}