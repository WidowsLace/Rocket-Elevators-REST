public class elevators
{
    public long id { get; set; }
    public string serial_number { get; set; }
    public string model { get; set; }
    public string building_type { get; set; }
    public string status { get; set; }
    public string commission_date { get; set; }
    public string last_inspection_date { get; set; }
    public string certificate_of_inspection { get; set; }
    public string information { get; set; }
    public string notes { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public int column_id { get; set; }
}