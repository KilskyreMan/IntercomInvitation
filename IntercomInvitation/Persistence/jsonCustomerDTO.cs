namespace IntercomInvitation.Persistence
{
    /// <summary>
    /// A Customer DTO (Data Transfer Object) as represented in customers.json.
    /// </summary>
    internal class jsonCustomerDTO
    {
        public double latitude { get; set; }
        public int user_id { get; set; }
        public string name { get; set; }
        public double longitude { get; set; }
    }
}
