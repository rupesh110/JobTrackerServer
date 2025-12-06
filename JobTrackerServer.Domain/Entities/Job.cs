namespace JobTrackerServer.Domain.Entities;

public class Job
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Company { get; private set; }


    public Job(string newTitle, string newCompany)
    {
        setTitle(newTitle);
        SetCompany(newCompany);
    }

    private void setTitle(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException("Title cannot be null or empty.", nameof(title));
        }
        Title = title;
    }

    private void SetCompany(string company)
    {
        if (string.IsNullOrWhiteSpace(company))
        {
            throw new ArgumentException("Company cannot be null or empty.", nameof(company));
        }
        Company = company;
    }
}