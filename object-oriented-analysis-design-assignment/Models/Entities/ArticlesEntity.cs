using object_oriented_analysis_design_assignment.Factories;
using System.Security.Cryptography;
using System.Text;
using object_oriented_analysis_design_assignment.Models.Dtos;
using object_oriented_analysis_design_assignment.Interfaces;

namespace object_oriented_analysis_design_assignment.Models.Entities
{
    public class ArticlesEntity : Articles
    {
        private Guid id;

        public int Id { get; set; }
        public byte[] PHash { get; set; } = null!;
        public byte[] PKey { get; set; } = null!;

        public Guid Id { get => id; set => id = value; }
        public byte[] PasswordHash { get; private set; }
        public string SecurityStamp { get; set; }
        public byte[] SecurityKey { get; private set; }
        public static object ArticlesResponseFactory { get; private set; }

        public static implicit operator IArticles(ArticlesEntity entity)
        {
            var res = IArticlesResponse.Create(); }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;
        public DateTime PublishedDate { get; set; }
        public bool IsPublished { get; set; }
        public string Author { get; set; } = null!;

            return res;
        }

        public void GenerateSecurePassword(string password)
        {
            using var hmac = (HMACSHA512)HmacFactory.Create();
            SecurityKey = hmac.Key;
            PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
    }
