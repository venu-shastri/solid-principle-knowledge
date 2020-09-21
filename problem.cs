public class Printer{

  public void Print(){ }
}

public class Scanner{

public void Scan(){}

}

public class PrintScanner : Printer, Scanner{



}

public class DeviceManager{

public void PrintTask(Printer p){

  p.Print();
}

public void Scantask(Scanner s){

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
