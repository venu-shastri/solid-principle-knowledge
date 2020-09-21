public class Patient{

public strimg MRN{get;set;}
public string Name{get;set;}
public string Phone{get;set;}
public string PinCode{get;set;}
publis string DOB{get;set;}
}

public static class PatientRepsoitory{

public static List<Patient> ListOfPatients=new  List<Patient>();

public void AddNewPatient(Patient model) { ListOfPatients.Add(model);}


}

public interface ISearchFilter{
 
  bool Search(Patient source);
}

public class SearchByMrnFilter:ISearchFilter{
 
  string mrn;
  public SearchByMrn(string mrn){ this.mrn=mrn;}
  public bool Search(Patient source){
    
    return source.MRN==tjis.mrn;
  }
}
public class SearchByNameFilter:ISearchFilter{
 
  string name;
  public SearchByMrn(string name){ this.name=name;}
  public bool Search(Patient source){
    
    return source.Name==this.name;
  }
}
//Open Close Principle  Issues
public class PatientSeacrhService{

  public IEnumerable<Patient> GetAllPatients(){
    return PatientRepository.ListOfPatients;
  }
  
  public IEnumerable<Patient> SearchByCriteria(ISerachFilter filter)
  {
    List<Patient> _resultList=new List<Patient>();
    foreach(Patient p in this.GetAllPatients){
      if(filter.Search(p)){
        _resultList.Add(p);
      }
    }
    return _resultList;
         
  }
 
  public IEnumerable<Patient> SearchByCriteriaUsingDelegates(Func<Patient,bool> filterAddress)
  {
    List<Patient> _resultList=new List<Patient>();
    foreach(Patient p in this.GetAllPatients){
      if(filterAddress.Invoke(p)){
        _resultList.Add(p);
      }
    }
    return _resultList;
         
  }
 

 

public class MainClass()
{
 static bool SearchByPin(Patient){
  
  return Patient.PinCode=="5600077";
 }
 
 static void Main(){

  SearchService _service=new SearchService();
  ISearchFilter _filter=new SearchByMrnFilter("MRN001");
 _filter=new SearchByNameFilter("Tom");
 IEnumerable<Patient> _patients= _service.SearchByCriteria(_filter);
  
  Func<Patient,bool> _funPtr=new Func<Patient,bool>(MainClass.SearchByPin);
  _service.SearchByCriteriaUsingDelegates(_funPtr);
  
  _service.SearchByCriteriaUsingDelegates((Patient p)=>{ return p.Name=="Hary"});
 
}
