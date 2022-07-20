namespace App.EndPoints.UI.Areas.Admin.Models
{
    public class UsersViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public int PictureFileId { get; set; }
        public string HomeAddress { get; set; }
        public Task<IList<string>> Roles { get; set; }
    }
}
