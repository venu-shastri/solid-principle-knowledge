class StringValidator{

  public bool Validate(string input){
  
    isValid=false;
    if(input!=null && input!=""){
     isValid=true;
    }
     return isValid;
  }

}
