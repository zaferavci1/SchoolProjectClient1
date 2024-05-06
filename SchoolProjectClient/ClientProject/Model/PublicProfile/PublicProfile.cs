using System;
namespace SchoolProjectClient.Client.Model.PublicProfile
{
    public class PublicProfile
    {
        public string Id { get; set; }
        public string NickName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public byte ProfilePictureId { get; set; }
    }

    public class PublicProfileResponse
    {
        public List<PublicProfile> PublicProfiles { get; set; }
        public int TotalPublicProfileCount { get; set; }
    }
}

