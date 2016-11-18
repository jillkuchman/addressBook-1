using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _=>
      {
        List<Contact> allContacts = Contact.DisplayAll();

        return View["index.cshtml", allContacts];
      };

      Get["/deleteAll"] = _=>
      {
        Contact.Empty();
        List<Contact> allContacts = Contact.DisplayAll();
        return View["index.cshtml", allContacts];
      };
      Get["/add"] = _=>
      {
        return View["add_contact.cshtml"];
      };
      Post["/new"] = _=>
      {
        Contact newContact = new Contact ( Request.Form["firstN"], Request.Form["lastN"], Request.Form["phone"], Request.Form["address"]);
        return View["new_contact.cshtml", newContact];
      };
      Get["/see/{id}"] = parameters =>
      {
        Contact aContact = Contact.Find(parameters.id);
        return View["see_contact.cshtml", aContact ];
      };
    }
  }
}
