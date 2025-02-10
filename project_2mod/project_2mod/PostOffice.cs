using System;
using System.Text;
using System.Globalization;
using System.IO;
namespace project_2mod;

public class PostOffice
{
    public string StateName { get; set; }
    public string PlaceName { get; set; }
    public string PostCode { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public PostOffice(string stateName, string placeName, string postCode, double latitude, double longitude)
    {
        StateName = stateName;
        PlaceName = placeName;
        PostCode = postCode;
        Latitude = latitude;
        Longitude = longitude;
    }
}