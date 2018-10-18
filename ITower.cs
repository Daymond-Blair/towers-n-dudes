namespace BlairDefense
{
    interface ITower : IMappable
    {
    int Range{get;}
    int Power{get;}
    double Accuracy{get;}
    
     bool IsSuccessfulShot();
    
     void FireOnDudes(IDude[] dudes);
    }
}