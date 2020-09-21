
public interface IPrintScanner{
 
  void Print();
  
}

public interface IScanner{
 
  void Scan();
}
public class Printer :IPrinter{

  public void Print(){ }
  
}

public class Scanner : IScanner{

public void Scan(){}

}

public class PrintScanner:IPrinter,IScanner{

  Printer pObj=new Printer();
  Scanner sObj=new Scanner();
  public void Print(){
    pObj.Print(); // Delegation 
  }
public void Scan(){
 
  sObj.Scan();
}

}

public class DeviceManager{

public void PrintTask(IPrinter p){

  p.Print();
}

public void Scantask(IScanner s){

  s.Scan();
}

}

public class Program{

  static void Main(){
    Printer p=new Printer();
    Scanner s=new Scanner();
    PrintScanner ps=new PrintScanner();
    
    DeviceManager dm=new DeviceManager();
    dm.PrintTask(p);
    dm.PrintTask(ps);
    
    dm.ScanTask(s);
    dm.ScanTask(ps);
    
  }
}
