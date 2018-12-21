using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class validateStuff
{
    public const string NorthAmericanPhonePattern = @"^(\+?(?<NatCode>1)\s*[-\/\.]?)?(\((?<AreaCode>\d{3})\)|(?<AreaCode>\d{3}))\s*[-\/\.]?\s*(?<Number1>\d{3})\s*[-\/\.]?\s*(?<Number2>\d{4})\s*(([xX]|[eE][xX][tT])\.?\s*(?<Ext>\d+))*$";


    public string getStateName(string state)
    {
        string outState = "";
        switch (state)
        {
            
            case "AL":
                outState = "Alabama";
                break;
            case "AK":
                outState = "Alaska";
                break;
            case "AZ":
                outState = "Arizona";
                break;
            case "AR":
                outState = "Arkansas";
                break;
            case "CA":
                outState = "California";
                break;
            case "CO":
                outState = "Colorado";
                break;
            case "CT":
                outState = "Connecticut";
                break;
            case "DE":
                outState = "Delaware";
                break;
            case "FL":
                outState = "Florida";
                break;
            case "GA":
                outState = "Georgia";
                break;
            case "HI":
                outState = "Hawaii";
                break;
            case "ID":
                outState = "Idaho";
                break;
            case "IL":
                outState = "Illinois";
                break;
            case "IN":
                outState = "Indiana";
                break;
            case "IA":
                outState = "Iowa";
                break;
            case "KS":
                outState = "Kansas";
                break;
            case "KY":
                outState = "Kentucky";
                break;
            case "LA":
                outState = "Louisiana";
                break;
            case "ME":
                outState = "Maine";
                break;
            case "MD":
                outState = "Maryland";
                break;
            case "MA":
                outState = "Massachusetts";
                break;
            case "MI":
                outState = "Michigan";
                break;
            case "MN":
                outState = "Minnesota";
                break;
            case "MS":
                outState = "Mississippi";
                break;
            case "MO":
                outState = "Missouri";
                break;
            case "MT":
                outState = "Montana";
                break;
            case "NE":
                outState = "Nebraska";
                break;
            case "NV":
                outState = "Nevada";
                break;
            case "NH":
                outState = "New Hampshire";
                break;
            case "NJ":
                outState = "New Jersey";
                break;
            case "NM":
                outState = "New Mexico";
                break;
            case "NY":
                outState = "New York";
                break;
            case "NC":
                outState = "North Carolina";
                break;
            case "ND":
                outState = "North Dakota";
                break;
            case "OH":
                outState = "Ohio";
                break;
            case "OK":
                outState = "Oklahoma";
                break;
            case "OR":
                outState = "Oregon";
                break;
            case "PA":
                outState = "Pennsylvania";
                break;
            case "RI":
                outState = "Rhode Island";
                break;
            case "SC":
                outState = "South Carolina";
                break;
            case "SD":
                outState = "South Dakota";
                break;
            case "TN":
                outState = "Tennessee";
                break;
            case "TX":
                outState = "Texas";
                break;
            case "UT":
                outState = "Utah";
                break;
            case "VT":
                outState = "Vermont";
                break;
            case "VA":
                outState = "Virginia";
                break;
            case "WA":
                outState = "Washington";
                break;
            case "WV":
                outState = "West Virginia";
                break;
            case "WI":
                outState = "Wisconsin";
                break;
            case "WY":
                outState = "Wyoming";
                break;
            case "DC":
                outState = "Washington DC";
                break;
            default:
                outState = "Invalid State Code";
                break;
        }



        return outState;
    }
    
    public string getValidState(string inStateCode)
    {
        // When a program often has to try keys that turn out not to
        // be in the dictionary, TryGetValue can be a more efficient 
        // way to retrieve values.
       Dictionary<string,string> myStates =  buildStateDictionary();

        string value = "";
        if (myStates.TryGetValue(inStateCode, out value))
        {
            return value;
        }
        else
        {
            return string.Format("invalid");
        }
    }
    private Dictionary<string,string> buildStateDictionary()
    {
        Dictionary<string, string> validStates = new Dictionary<string, string>();

        
        validStates.Add("AL", "Alabama");
        validStates.Add("AK", "Alaska");
        validStates.Add("AZ", "Arizona");
        validStates.Add("AR", "Arkansas");
        validStates.Add("CA", "California");
        validStates.Add("CO", "Colorado");
        validStates.Add("CT", "Connecticut");
        validStates.Add("DE", "Delaware");
        validStates.Add("FL", "Florida");
        validStates.Add("GA", "Georgia");
        validStates.Add("HI", "Hawaii");
        validStates.Add("ID", "Idaho");
        validStates.Add("IL", "Illinois");
        validStates.Add("IN", "Indiana");
        validStates.Add("IA", "Iowa");
        validStates.Add("KS", "Kansas");
        validStates.Add("KY", "Kentucky");
        validStates.Add("LA", "Louisiana");
        validStates.Add("ME", "Maine");
        validStates.Add("MD", "Maryland");
        validStates.Add("MA", "Massachusetts");
        validStates.Add("MI", "Michigan");
        validStates.Add("MN", "Minnesota");
        validStates.Add("MS", "Mississippi");
        validStates.Add("MO", "Missouri");
        validStates.Add("MT", "Montana");
        validStates.Add("NE", "Nebraska");
        validStates.Add("NV", "Nevada");
        validStates.Add("NH", "New Hampshire");
        validStates.Add("NJ", "New Jersey");
        validStates.Add("NM", "New Mexico");
        validStates.Add("NY", "New York");
        validStates.Add("NC", "North Carolina");
        validStates.Add("ND", "North Dakota");
        validStates.Add("OH", "Ohio");
        validStates.Add("OK", "Oklahoma");
        validStates.Add("OR", "Oregon");
        validStates.Add("PA", "Pennsylvania");
        validStates.Add("RI", "Rhode Island");
        validStates.Add("SC", "South Carolina");
        validStates.Add("SD", "South Dakota");
        validStates.Add("TN", "Tennessee");
        validStates.Add("TX", "Texas");
        validStates.Add("UT", "Utah");
        validStates.Add("VT", "Vermont");
        validStates.Add("VA", "Virginia");
        validStates.Add("WA", "Washington");
        validStates.Add("WV", "West Virginia");
        validStates.Add("WI", "Wisconsin");
        validStates.Add("WY", "Wyoming");
        validStates.Add("DC", "Washington DC");



        return validStates;
    }
    public bool validCharacters(string inString)
    {
        return false;
    }
    public bool validNumeric(string inString)
    {
        return false;
    }
    private string PhoneNumberMatchEvaluator(System.Text.RegularExpressions.Match match)
    {
        // Format to north american style phone numbers "0 (000) 000-0000"
        //                                          OR  "(000) 000-0000"
        System.Diagnostics.Debug.Assert(match.Success);
        if (match.Groups["NatCode"].Success)
        {
            return match.Result("${NatCode} (${AreaCode}) ${Number1}-${Number2}");
        }
        else
        {
            return match.Result("(${AreaCode}) ${Number1}-${Number2}");
        }
    }


    public string FormatPhoneNumber(string phoneNumber)
    {
        var regex = new System.Text.RegularExpressions.Regex(NorthAmericanPhonePattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        return regex.Replace(phoneNumber, new System.Text.RegularExpressions.MatchEvaluator(PhoneNumberMatchEvaluator));
    }


}
public class stateList : IComparable
{
    public string stateCode { get; set; }
    public string stateName { get; set; }

    public int CompareTo(object obj)
    {
        stateList state = (stateList)obj;

        return this.stateCode.CompareTo(state.stateCode);
    }
    public List<stateList> buildStateList()
    {
        List<stateList> listOfStates = new List<stateList>();

        stateList state = new stateList();

        state.stateCode = "AL";
        state.stateName = "Alabama";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "AK";
        state.stateName = "Alaska";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "AZ";
        state.stateName = "Arizona";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "AR";
        state.stateName = "Arkansas";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "CA";
        state.stateName = "California";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "CO";
        state.stateName = "Colorado";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "CT";
        state.stateName = "Connecticut";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "DE";
        state.stateName = "Delaware";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "FL";
        state.stateName = "Florida";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "GA";
        state.stateName = "Georgia";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "HI";
        state.stateName = "Hawaii";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "ID";
        state.stateName = "Idaho";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "IL";
        state.stateName = "Illinois";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "IN";
        state.stateName = "Indiana";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "IA";
        state.stateName = "Iowa";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "KS";
        state.stateName = "Kansas";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "KY";
        state.stateName = "Kentucky";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "LA";
        state.stateName = "Louisiana";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "ME";
        state.stateName = "Maine";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "MD";
        state.stateName = "Maryland";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "MA";
        state.stateName = "Massachusetts";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "MI";
        state.stateName = "Michigan";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "MN";
        state.stateName = "Minnesota";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "MS";
        state.stateName = "Mississippi";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "MO";
        state.stateName = "Missouri";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "MT";
        state.stateName = "Montana";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "NE";
        state.stateName = "Nebraska";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "NV";
        state.stateName = "Nevada";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "NH";
        state.stateName = "New Hampshire";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "NJ";
        state.stateName = "New Jersey";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "NM";
        state.stateName = "New Mexico";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "NY";
        state.stateName = "New York";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "NC";
        state.stateName = "North Carolina";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "ND";
        state.stateName = "North Dakota";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "OH";
        state.stateName = "Ohio";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "OK";
        state.stateName = "Oklahoma";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "OR";
        state.stateName = "Oregon";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "PA";
        state.stateName = "Pennsylvania";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "RI";
        state.stateName = "Rhode Island";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "SC";
        state.stateName = "South Carolina";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "SD";
        state.stateName = "South Dakota";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "TN";
        state.stateName = "Tennessee";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "TX";
        state.stateName = "Texas";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "UT";
        state.stateName = "Utah";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "VT";
        state.stateName = "Vermont";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "VA";
        state.stateName = "Virginia";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "WA";
        state.stateName = "Washington";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "WV";
        state.stateName = "West Virginia";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "WI";
        state.stateName = "Wisconsin";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "WY";
        state.stateName = "Wyoming";
        listOfStates.Add(state);
        state = new stateList();
        state.stateCode = "DC";
        state.stateName = "Washington DC";
        listOfStates.Add(state);


        listOfStates.Sort();
        return listOfStates;
    }
}


