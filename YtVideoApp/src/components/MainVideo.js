import React, { Component } from 'react';
import { connect } from 'react-redux';
import { Embed } from 'semantic-ui-react';
import './MainVideo.css'

class MainVideo extends Component {
    render() {
        const v = this.props.selectedVideo;
        
        if (v != null){
            return (
                <div>
                    <Embed id={v.id.videoId} 
                        placeholder={v.snippet.thumbnails.high.url}
                        source='youtube'/>
                </div>
            );        
        }

        if (this.props.isVideoFetching){
            return <div className="ui active centered inline loader large"></div>;
        }

        return null; 
    }
}

const mapStateToProps = (state) => {
    return  {
        selectedVideo: state.videos.selectedVideo,
        isVideoFetching: state.videos.isVideoFetching
     };
}

export default connect(mapStateToProps)(MainVideo);

