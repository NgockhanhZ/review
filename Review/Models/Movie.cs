using System.ComponentModel.DataAnnotations;

namespace Review.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tiêu đề là bắt buộc.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Mô tả là bắt buộc.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Ngày phát hành là bắt buộc.")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Thể loại là bắt buộc.")]
        public string Genre { get; set; }

        [Url(ErrorMessage = "URL ảnh không hợp lệ.")]
        public string ImageURL { get; set; }

        [Url(ErrorMessage = "Link phim không hợp lệ.")]
        public string Link { get; set; }
    }
}
