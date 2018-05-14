This is a simple backend I made in the style of a headless CMS to power a fantasy football league blog.

It utilizes a .net Core WebAPI project to grab markdown files in the "md" directory.

Posts is a general controller that will grab all posts in the md folder as well as respond to requests for individual markdown files.

i.e. (domain)/api/posts will return all an array of the contents of all files in the "md" directory.

(domain)/api/posts/announcements will return just the contents of the "announcements.md" file in the "md" directory.
