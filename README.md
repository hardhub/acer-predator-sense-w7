# Acer PredatorSense for Windows 7 x64
This small .Net program allows to install Predator Sense software on Windows 7.  
Due to unknown reason Acer does not provide drivers for Windows 7 for Predator notebooks.  
Such software as PredatorSence is very specific and cannot be obtained from vendors (like it is for GPU or touchpads).
But many people still prefer Windows 7 since it is very comfortable for work (and because it will never update PC in the worst moment).  
So.. Let's go!  

# How to use it?
First you need to download PredatorSense from Acer site or you can get one from repository (used for testing and compiling).  
Then you need to download Setup.W7.exe (or compile your own from source).
This binary should be placed into root directory of PredatorSense (aside Setup.exe)  
After that just run Setup.W7.exe instead original setup file.  
It will patch OS version in memory and run all desired logic to start MSI installation.  

# Warnings!
Since this package is not supported by Acer on Windows 7 we cannot know how it will work.  
I have tested it a bit and it looks very promsing.  
The single issue I experienced was message about missing package during installation (RT).  
All that is of course resonable...But fortunately we can simply skip this message.  
Just continue installation. PredatorSense should work.  

And of course remember all that is only for your own risk! :)  
