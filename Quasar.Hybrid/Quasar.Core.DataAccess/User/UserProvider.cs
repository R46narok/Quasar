using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;

namespace Quasar.Core.DataAccess
{
    /// <summary>
    /// 
    /// </summary>
    public class UserProvider
    {
        private IMongoCollection<User> _userCollection;
        public UserProvider(DatabaseConnection helper)
        {
            _userCollection = helper.Database
                .GetCollection<User>(DatabaseConnection.UserCollection);
        }

        #region User registration

        /// <summary>
        /// Checks if a user with the provided username/email exists.
        /// If the credentials are unique, a record is created in the database and the
        /// registration is successful.
        /// </summary>
        /// <param name="user">The following properties are required to be valid:
        /// Username, Email, PasswordHash, PasswordSalt, PasswordIterations</param>
        /// <returns>True if the credentials are unique.</returns>
        public bool RegisterUser(User user)
        {
            var usernameFilter = Builders<User>.Filter.Eq(u => u.Username, user.Username);
            var emailFilter = Builders<User>.Filter.Eq(u => u.Email, user.Email);

            var usernameRecord = _userCollection.Find(usernameFilter).FirstOrDefault();
            var emailRecord = _userCollection.Find(emailFilter).FirstOrDefault();

            if (usernameRecord == null && emailRecord == null)
            {
                _userCollection.InsertOne(user);
                return true;
            }

            return false;
        }

        #endregion

        #region User authentication

        /// <summary>
        /// Fetches the dynamic salt and iterations of a user for it to be sent back to the client
        /// and used for generating the final hash for comparison. 
        /// </summary>
        /// <param name="username">Valid username from the db.</param>
        /// <returns>Null if the username is not present in the db.</returns>
        public UserCredentialsInfo GetCredentialsInfo(string username)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Username, username);
            var dbRecord = _userCollection.Find(filter).FirstOrDefault();

            if (dbRecord != null)
            {
                return new UserCredentialsInfo
                {
                    PasswordSalt = dbRecord.PasswordSalt,
                    PasswordIterations = dbRecord.PasswordIterations
                };
            }

            return null;
        }

        /// <summary>
        /// Checks if a user with the provided username exists. If they do,
        /// the method compares the two password hashes(from the database and from the args) to
        /// authenticate a user.
        /// </summary>
        /// <param name="credentials">Valid username from the db.</param>
        /// <returns>Null if the username is not present.</returns>
        public User AuthenticateUser(UserCredentials credentials)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Username, credentials.Username);
            var dbRecord = _userCollection.Find(filter).FirstOrDefault();

            if (dbRecord != null && credentials.PasswordHash.SequenceEqual(dbRecord.PasswordHash))
            {
                return new User
                {
                    Email = dbRecord.Email,
                    Username = dbRecord.Username
                };
            }
                

            return null;
        }

        #endregion


    }
}
