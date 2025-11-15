import update from 'immutability-helper';

const initialSate = {
    videos: [],
    selectedVideo: null,
    searchTerm: '',
    isVideoFetching: false
};

export default (state = initialSate, action) => {
    switch (action.type) {
        case 'START_STOP_FETCHING':
            return update(state, {
                isVideoFetching: { $set: action.payload }
            });
        case 'FETCH_VIDEOS':
            return update(state, {
                videos: { $set: action.payload.filter((el, idx) => idx > 0) },
                selectedVideo: { $set: action.payload[0] },
            });
        case 'VIDEO_SELECTED':
            return update(state, {
                selectedVideo: { $set: action.payload },
            });
        case 'SEARCH_TERM_CHANGED':
            return update(state, {
                searchTerm: { $set: action.payload },
            });
        default:
            return state;
    }
}


