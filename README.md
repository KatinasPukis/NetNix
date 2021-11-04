# NetNix
The company NetNix is creating a new website where their movies are being promoted. They want to be able to promote movies that are soon to be released and next to that they would like to show more detailed information regarding the movies and their director. Their brand manager suggested that they would need to step on the social media community and have something like a 'Like' function. 
We ask of you to build the following pages:
1. Homepage with top 5 soon to be released movies ordered on releasedate (asc). The NetNix integration team created an endpoint at https://virtserver.swaggerhub.com/BartvdPost/NetNix/0.2.0/soon/ for this. You can use the GET method to retreive the list. The movie titles should be clickable and a new page should open with details regarding the movie.
 
2. A page with details of a movie and be able to like a movie there. The name of the director should be a link so interested people can see their details too on a new page.
GET: https://virtserver.swaggerhub.com/BartvdPost/NetNix/0.2.0/movie/<MOVIEID>
POST: https://virtserver.swaggerhub.com/BartvdPost/NetNix/0.2.0/like
3. A page with details regarding the director details. The NetNix integration team is working on this API call, so the details are super limited. You can use the endpoint https://virtserver.swaggerhub.com/BartvdPost/NetNix/0.2.0/director/<DIRECTORID> to retrieve the director details
