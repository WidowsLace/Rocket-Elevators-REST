public class batteries
{
    public long id { get; set; }
    public string building_type { get; set; }
    public string status { get; set; }
    public string commission_date { get; set; }
    public string last_inspection_date { get; set; }
    public string certificate_of_operations { get; set; }
    public string information { get; set; }
    public string notes { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public int building_id { get; set; }
    public int employee_id { get; set; }
}