using CSharpFunctionalExtensions;
using PetFamily.Domain.Models.Shared;

namespace PetFamily.Domain.Models.PetModel
{
    public record PetPhoto
    {
        private PetPhoto()
        {
            
        }
        public string Path { get;}

        public bool IsMainPhoto { get;}

        private PetPhoto(string path, bool isMainPhoto)
        {
            Path = path;
            IsMainPhoto = isMainPhoto;
        }

        public static Result<PetPhoto, Error> Create (string path, bool isMainPhoto)
        {
            if (string.IsNullOrWhiteSpace(path) || path.Length > Constants.MAX_HIGH_TEXT_LENGHT)
                return Errors.General.ValueIsInvalid("path");

            return new PetPhoto(path, isMainPhoto);
        }
    }
}
