using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {

    private string _firstN;
    private string _lastN;
    private int _phone;
    private string _address;
    private static List<Contact> _instance = new List<Contact> {};
    private int _id;

    public Contact(string firstN, string lastN, int phone, string address)
    {
      _firstN = firstN;
      _lastN = lastN;
      _phone = phone;
      _address = address;
      _instance.Add(this);
      _id = _instance.Count;
    }

    public void SetfirstN(string firstN)
    {
      _firstN = firstN;
    }
    public void SetLn(string lastN)
    {
      _lastN = lastN;
    }
    public void SetPhone(int phone)
    {
      _phone = phone;
    }
    public void Setaddress (string address)
    {
      _address = address;
    }



    public string GetfirstN ()
    {
      return _firstN;
    }
    public string GetlastN ()
    {
      return _lastN;
    }
    public int GetPhone ()
    {
      return _phone;
    }
    public string Getaddress()
    {
      return _address;
    }
    public int GetId ()
    {
      return _id;
    }



    public void Save()
    {
      _instance.Add(this);
    }
    public static List<Contact> DisplayAll()
    {
      return _instance;
    }


    public static bool CheckContacts()
    {
      if ( _instance.Count > 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public static Contact Find(int id)
    {
      return _instance[id - 1];
    }
    public static void Empty()
    {
      _instance.Clear();
    }
  }
}
