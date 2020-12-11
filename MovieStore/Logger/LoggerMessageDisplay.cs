using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Logger
{
    public class LoggerMessageDisplay
    {
        // Movie Messages
        public const string MoviesListed = "All movies listed successfully!";
        public const string NoMoviesInDB = "There is no movies in the DB!";
        public const string MovieFoundDisplayDetails = "Movie was found in the DB, show the details of the movie";
        public const string NoMovieFound = "This is no movie found in the DB!";
        public const string MovieCreated = "New movie is created in the DB";
        public const string MovieNotCreatedModelStateInvalid = "New movie is NOT created in the DB, ModelState is not valid";
        public const string MovieEdited = "Movie is edited successfully";
        public const string MovieEditNotFound = "Movie for editting is not found in the DB";
        public const string MovieEditErrorModelStateInvalid = "Movie is not edited, ModelState is not valid";
        public const string MovieDeleted = "Movie is deleted successfully";
        public const string MovieDeletedError = "Movie is NOT deleted, error happend in process of deletion";


        // Director Messages
        public const string DirectorsListed = "All directors listed successfully!";
        public const string NoDirectorsInDB = "There is no directors in the DB!";
        public const string DirectorFoundDisplayDetails = "Director was found in the DB, show the details of the director";
        public const string NoDirectorFound = "This is no director found in the DB!";
        public const string DirectorCreated = "New director is created in the DB";
        public const string DirectorNotCreatedModelStateInvalid = "New director is NOT created in the DB, ModelState is not valid";
        public const string DirectorEdited = "Director is edited successfully";
        public const string DirectorEditErrorModelStateInvalid = "Director is not edited, ModelState is not valid";
        public const string DirectorDeleted = "Director is deleted successfully";
        public const string DirectorDeletedError = "Director is NOT deleted, error happend in process of deletion";

        // Category Messages
        public const string CategoriesListed = "All categories listed successfully!";
        public const string NoCategoriesInDB = "There is no categories in the DB!";
        public const string CategoryFoundDisplayDetails = "Category was found in the DB, show the details of the category";
        public const string NoCategoryFound = "This is no category found in the DB!";
        public const string CategoryCreated = "New category is created in the DB";
        public const string CategoryNotCreatedModelStateInvalid = "New category is NOT created in the DB, ModelState is not valid";
        public const string CategoryEdited = "Category is edited successfully";
        public const string CategoryEditErrorModelStateInvalid = "Category is not edited, ModelState is not valid";
        public const string CategoryDeleted = "Category is deleted successfully";
        public const string CategoryDeletedError = "Category is NOT deleted, error happend in process of deletion";

        // Upload Photo Messages
        public const string PhotoUploaded = "Photo is successfully uploaded";
        public const string PhotoUploadedError = "Photo is NOT uploaded";
        public const string PhotosListed = "All photos listed successfully!";
        public const string NoPhotosInDB = "There is no photos in the DB!";
        public const string PhotoFoundDisplayDetails = "Photo was found in the DB, show the details of the photo";
        public const string NoPhotoFound = "This is no photo found in the DB!";
        public const string PhotoCreated = "New photo is created in the DB";
        public const string PhotoNotCreatedModelStateInvalid = "New photo is NOT created in the DB, ModelState is not valid";
        public const string PhotoEdited = "Photo is edited successfully";
        public const string PhotoEditErrorModelStateInvalid = "Photo is not edited, ModelState is not valid";
        public const string PhotoDeleted = "Photo is deleted successfully";
        public const string PhotoDeletedError = "Photo is NOT deleted, error happend in process of deletion";

        // User Messages
        public const string UsersListed = "All users listed successfully!";
        public const string NoUsersInDB = "There is no user in the DB!";
        public const string UserFoundDisplayDetails = "User was found in the DB, show the details of the user";
        public const string NoUserFound = "This is no user found in the DB!";
        public const string UserCreated = "New user is created in the DB";
        public const string UserNotCreatedModelStateInvalid = "New user is NOT created in the DB, ModelState is not valid";
        public const string UserEdited = "User is edited successfully";
        public const string UserEditErrorModelStateInvalid = "User is not edited, ModelState is not valid";
        public const string UserDeleted = "User is deleted successfully";
        public const string UserDeletedError = "User is NOT deleted, error happend in process of deletion";
    }
}
