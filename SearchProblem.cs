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

public class Main(){

  SearchService _service=new SearchService();
  ISearchFilter _filter=new SearchByMrnFilter("MRN001");
 IEnumerable<Patient> _patients= _service.SearchByCriteria(_filter);
}
