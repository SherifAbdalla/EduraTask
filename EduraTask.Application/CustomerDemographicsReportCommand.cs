using MediatR;

namespace EduraTask.Application;

public record CustomerDemographicsReportCommand : IRequest<IEnumerable<CustomerDemographicsReportResult>>
{
}

public record CustomerDemographicsReportResult
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public DateOnly Birthdate { get; set; }
    public string BookingName { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

