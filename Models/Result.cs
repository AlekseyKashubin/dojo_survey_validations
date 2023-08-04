#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;


// Notice the use of the "Models" tag the same way we put "Controllers" in our Controller file
namespace dojo_survey_validations.Models;
public class Result
{
    // We must put {get;set;} after all our properties
    // This will give ASP.NET Core the permissions it needs to modify the values    




    [Required]
    [MinLength(2)]
    public string Name {get;set;}



    [Required]
    public string Location {get;set;}



    [Required]
    public string FavLang {get;set;}


[MinLength(20)]
    public String? Comment {get;set;}
}
