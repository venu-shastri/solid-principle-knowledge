public class Camera{

public void Capture(){}
}

public class Phone{

public void Hangup(){}
public void Rlease(){}
}

public class GPSDevice{

  public void Navigate(){}
}

public class SmartPhone:Camera, Phone, GPSDevice{}

public class PhotoGrpaher{

  public void CaptureRealObjects(Camera c){ c.Capture();}
}

public class Traveller{

public void Navigate(GPSDevice gpd){ gpd.Navigate();}
}

public class Person{
  public void Communicate(Phone ph){ ph.Hangup(); ph.Release();}
  
}

public class EntryPoint{

  static void Main(){
  
    Phone p=new Phone();
    GPSDevice gps=new GPSDevice();
    Camera cam=new Camera();
    
    Traveller _trav=new Traveller();
    Person _per=ne Person();
    Photographer _photo=new Photographer();
    
    _trav.Navigate(gps);
    _per.Communicate(p);
    _photo.CaptureRealObjects(cam);
    
    SmartPhone _sm=new SmartPhone();
    _trav.Navigate(sm);
    _per.Communicate(sm);
    _photo.CaptureRealObjects(sm);
    
    
    
  }

}

