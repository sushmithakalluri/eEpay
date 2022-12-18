using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

	[OperationContract]
	[WebInvoke(Method = "POST", UriTemplate = "/Insert/{customers}", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
	void Insert(Customer[] customers);


    [OperationContract]
    [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/Get", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
    List<Customer> Get();

}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class Customer
{
    [DataMember]
    [Required(ErrorMessage = "Firstname is a required field.")]
    public string firstName { get; set; }

    [DataMember]
    [Required(ErrorMessage = "Firstname is a required field.")]
    public string lastName { get; set; }

    [DataMember]
    [Required(ErrorMessage = "Age is a required field.")]
    [Range(18, 100, ErrorMessage = "A persons age must be between 18 and 100.")]
    public int age { get; set; }

    [DataMember]
    [Required(ErrorMessage = "ID is a required field.")]
    [Index(IsUnique = true)]
    public int id { get; set; }
}