# CodeFirstRelationPractic

Creating Databases and Relationships with Code First Approach

User Table:

Id: int, primary key and auto-incrementing.

Username: string, user's username.

Email: string, user's email address.

Post Table:

Id: int, primary key and auto-incrementing.

Title: string, post title.

Content: string, post content.

UserId: int, post author (user's ID).

A user can have multiple posts, but each post will belong to only one user.

### technology used
- C#
- Asp. Net Core Web Api
- Entity Framework
