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
//Open Close Principle  Issues
public class PatientSeacrhService{

  public IEnumerable<Patient> GetAllPatients(){
    return PatientRepository.ListOfPatients;
  }
  
  public Patient SearchByMRN(string mrn)
  {
      //Search Based On MRN
      return default(Patient)
  }
  public IEnumerable<Patient> SearchByName(string name){
  
  }
}

public class Main(){

  SearchService _service=new SearchService();
  _service.SearchByMRN("MRN001");
}
