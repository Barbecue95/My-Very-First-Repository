const playlistContainertag = document.getElementsByClassName(
    "playlistContainer"
)[0];

const audioTag = document.getElementsByClassName("audioTag")[0];

const currentAndTotalTimeTag = document.getElementsByClassName("currentAndTotalTime")[0];

const currentProgressTag = document.getElementById("CurrentProgress");

const playButtonTag = document.getElementsByClassName("playButton")[0];
const pauseButtonTag = document.getElementsByClassName("pauseButton")[0];
const previousButtonTag = document.getElementsByClassName("previosButton")[0];
const nextButtonTag = document.getElementsByClassName("nextButton")[0]

const tracks= [
    { trackId:"music/Charlie_Puth_Light_Switch_Official_Music_Video_.mp3", title:"Light Switch - Charile Puth"},
    { trackId:"music/Charlie_Puth_That_s_Hilarious_Official_Video_.mp3",   title:"That's Hilarious - Charile Puth"},
    { trackId: "music/Wiz_Khalifa_See_You_Again_feat_Charlie_Puth_.mp3",   title:"See You Again - Charile Puth"},
];

for (let i=0; i < tracks.length; i++ ) {
    const trackTag = document.createElement("div");
    trackTag.addEventListener ("click", () => {
        currentPlayIndex = i;
       playSong();
    });
    trackTag.classList.add("trackItem");
    const title = (i + 1).toString() + ". " + tracks[i].title;
    trackTag.textContent = title;
    playlistContainertag.append (trackTag);
}

let duration = 0;
let durationText = "00:00"
audioTag.addEventListener ("loadeddata", () => {
    duration = Math.floor(audioTag.duration);
    createMinuteAndSecondText(duration);
    durationText = createMinuteAndSecondText(duration);
});

audioTag.addEventListener ("timeupdate", () => {
    const currentTime = Math.floor (audioTag.currentTime);
    const currentTimeText = createMinuteAndSecondText(currentTime);
    const currentTimeTextAnddurationText = currentTimeText + " / " + durationText;
    currentAndTotalTimeTag.textContent = currentTimeTextAnddurationText;
    updateCurrentProgress (currentTime);
 });

 const updateCurrentProgress = (currentTime) => {
    const CurrentProgressWidth = (400/duration) * currentTime ;
    currentProgressTag.style.width = CurrentProgressWidth.toString() + "px";
 }

const createMinuteAndSecondText = (totalSecond) => {
    const minutes = Math.floor(totalSecond/ 60);
    const seconds = totalSecond % 60;

    const minuteText = minutes < 10 ? "0" + minutes.toString() : minutes;
    const secondText = seconds < 10 ? "0" + seconds.toString() : seconds;
    return minuteText + ":" + secondText;

}

let currentPlayIndex = 0;
let isPlaying = false;
playButtonTag.addEventListener("click", () => {
    const currentTime = Math.floor (audioTag.currentTime);
    isPlaying = true;
    if (currentTime === 0) {
      playSong();
    }else {
        audioTag.play();
        UpdatePlayAndPauseButton();
    }
});

pauseButtonTag.addEventListener ("click", ()=> {
    isPlaying = false;
    audioTag.pause();
    UpdatePlayAndPauseButton();
});

previousButtonTag.addEventListener ("click", () => {
    if (currentPlayIndex === 0 ) {
        return;
    }
    currentPlayIndex -= 1;
    playSong();
});

nextButtonTag.addEventListener("click", ()=> {
    if (currentPlayIndex === tracks.length - 1) {
        return;
    }
    currentPlayIndex += 1;
    playSong();
});

const playSong = () => {
    const songIdToplay = tracks [currentPlayIndex].trackId;
    audioTag.src =songIdToplay;
    audioTag.play();
    isPlaying = true;
    UpdatePlayAndPauseButton();
}

const UpdatePlayAndPauseButton = () => {
    if (isPlaying) {
        playButtonTag.style.display = "none";
        pauseButtonTag.style.display = "inline";
    }else {
        playButtonTag.style.display ="inline";
        pauseButtonTag.style.display = "none";
    }
};