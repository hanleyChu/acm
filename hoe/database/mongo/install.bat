md data
md data\db
md log

net stop MongoDB
bin\mongod.exe --remove

bin\mongod.exe --journal --dbpath %CD%\data\db --logpath %CD%\log\mongo.log --install
net start MongoDB


