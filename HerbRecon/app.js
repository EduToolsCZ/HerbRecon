if(require('electron-squirrel-startup')) return;

const {app, BrowserWindow, autoUpdater, ipcMain} = require('electron');
try{
	autoUpdater.setFeedURL('http://sorashi.xf.cz/projects/herbrecon/releases');
	autoUpdater.checkForUpdates();
	autoUpdater.on('update-downloaded', function() {
		autoUpdater.quitAndInstall();
	});
}catch(err){
	console.log("Squirrel was probably not found, which means that this is not a release version.\n"+
		"Update debugging isn't possible at the moment.\n" + err.message);
}

let win

function createWindow(){
	win = new BrowserWindow({
		width: 800,
		height: 600
	});
	win.loadURL('file://' + __dirname + '/index.html');
	win.on('closed', function(){
		win = null;
	});
	ipcMain.on('start', (event, arg) => {
		console.log('Start clicked.');
		event.returnValue = null;
	});
}

app.on('ready', createWindow);