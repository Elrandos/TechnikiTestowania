import axios from 'axios';
import Config from '../appconfig'

export const fetchVideos = () => async (dispacth, getState) => {
    const term = getState().videos.searchTerm;
    if (term) {
        const url = "https://www.googleapis.com/youtube/v3/search?maxResults=5&part=snippet"
        const response = await axios.get(url,
            {
                params:
                {
                    key: Config.youtubeApiKey,
                    q: term
                }
            });

        return dispacth({ type: "FETCH_VIDEOS", payload: response.data.items });
    }
}

export const onSearchTermChanged = (term) => {
    return {
        type: "SEARCH_TERM_CHANGED",
        payload: term
    }
}

export const selectVideo = (video) => {
    return {
        type: "VIDEO_SELECTED",
        payload: video
    }
}

export const setIsFetching = (status) => {
    return {
        type: "START_STOP_FETCHING",
        payload: status
    }
}

const sleep = (ms) => {
    return new Promise(resolve => setTimeout(resolve, ms));
}

