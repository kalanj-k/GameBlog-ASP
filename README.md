# GameBlog-ASP
 
A school project. Intended to be used for a website to help find players for tabletop games.  

Code-first approach used with the database.  
Pagination.  
JWT used.  
Used FluentValidator for endpoints which require changes in the database.  
Used AutoMapper when updating users and posts.  
When registering, users recieve a confirmation email.  
Users are able to create posts with images, as well as update and delete them.  
Users are able to create comments.  
Users are able to like posts.  

#### Anonymous users can: ####
- register
- browse categories
- browse all posts under a specific category
- browse all posts
- view a single post  

#### Registered users can: ####
- all of the above
- create post
- update post
- delete post
- like
- remove like
- comment
- update comment
- delete comment
- search users
- view single user

#### Admin users can: ####
- all of the above
- create category
- update category
- delete category
- delete comment
- create user
- update user
- delete user
- delete post
- browse UseCase logs

### Database: ###

![image](https://user-images.githubusercontent.com/51056981/220648767-80a86992-0ebe-465a-8a58-442d14396782.png)
