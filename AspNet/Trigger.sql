--use CoreDemo

--Create Trigger AddBlogInRatingsTable
--on Blogs 
--after insert 
--as 
--Declare @ID int
--Select @ID=Id from inserted
--insert into BlogRatings (BlogId,TotalScore,RatingCount)
--values (@ID,0,0)



Create Trigger AddScoreInComment
on Comments
after insert
as
Declare @ID int
Declare @Score int
Declare @RatingCount int
Select @ID=BlogId,@Score=Score from inserted
Update BlogRatings Set TotalScore=TotalScore+@Score, RatingCount+=1
Where BlogId=@ID