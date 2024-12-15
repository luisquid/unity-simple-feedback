# Simple Feedback Form for Unity
This is a simple feedback form package that you can implement to gather in-game feedback of your game or application. This uses Google Forms as a way to receive feedback, so it requires some setup on [Google Forms](https://docs.google.com/forms/u/0/). 
<img src="https://github.com/user-attachments/assets/b9b8356d-47c9-4b1e-bb0c-54c376b21f6c" alt="image" style="width:50%; height:auto;">

## Installation Steps:
1. Download the package to your project.
2. In the Simple Feedback Form folder you will find the Simple Feedback Form prefab. Drag it to the first scene of your game.
3. Inside the Simple Feedback Form you will find the Feedback Form script attahced to the Simple Feedback Canvas where you will need to do some additional setup explained below. 

## Setup Steps
1. Create a Google Forms form.
2. Add three different questions. The first one will be used for the name of the person giving the feedback, the second one for the email of said person, and the last one for the feedback comments.
3. Set the first initial questions as short answer types, and the third question to the long answer type.
   <img src="https://github.com/user-attachments/assets/36f41445-53a1-48e6-bd92-cbbfc18b9f30" alt="image" style="width:50%; height:auto;">

4. Publish the form, and on the Responses section click on the "Link to Sheets" button to create the spreadsheet where the feedback will be stored.

   <img src="https://github.com/user-attachments/assets/248df41b-c660-49db-af19-e29516c1a954" alt="image" style="width:50%; height:auto;">
6. On the published form right click and go to the page source.

   <img src="https://github.com/user-attachments/assets/47293cda-1877-42ec-be83-b6dfd0946f2e" alt="image" style="width:50%; height:auto;">
8. Use Ctrl or Cmd + F to search for `formResponse`. Copy that URL and paste it on the BaseURL field of the Feedback Form script.
   ![image](https://github.com/user-attachments/assets/edb920b6-873c-4324-854c-eebe0e662b42) ![baseURL](https://github.com/user-attachments/assets/12aba8f5-0068-47ea-a73f-1fa59a3cdaeb)
9. Go back to the published form, right click and select inspect element.
10. Use Ctrl or Cmd + F on the Developer Console to search `entry`.
   ![image](https://github.com/user-attachments/assets/32745380-be12-4e1f-ad02-948b7198b5c0)
11. You will find three different input objects. Copy each of their names and paste them on the Username, Email and Feedback ID fields respectively.
    ![Input Field IDs](https://github.com/user-attachments/assets/282b2a31-e3e3-4941-8a2c-73855ebb9ce0)
12. Go back to the FeedbackForm script, select the Feedback Key to be able to show the feedback form in game.
    ![image](https://github.com/user-attachments/assets/2d1fd924-9d6c-418f-99e8-40a16a9f0a4d)
13. Go back to your scene, click play and test it out! 

## Supported Unity Versions
- v6000.0.26f1

## Supported Platforms
- Standalone Windows

## Disclaimer
This package is provided as is and no support will be given to it. Feel free to fork it and adapt it to your needs. The supported Unity versions and Platforms are limited to the ones I was able to test on my own. That does not mean that it won't work in other versions/platforms, but I can't guarantee that it will. 
