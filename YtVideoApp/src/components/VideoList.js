import React, { Component } from 'react';
import { connect } from 'react-redux';
import { selectVideo } from '../actions';
import PropTypes from 'prop-types';

class VideoList extends Component {
    render() {
        console.log(this.props);
        if (this.props.videos.length > 0) {
            return (
                <div>
                    {this.renderVideos()}
                </div>
            )
        }

        return this.props.isVideoFetching
            && <div className="ui active centered inline loader large"></div>;
    }

    renderVideos() {    
        return this.props.videos.map(v =>
            <div key={v.etag} className="ui segment">
                <div className="content">
                    <h3 className="ui header">{v.snippet.title}</h3>
                </div>
                <div className="content" style={{ position: 'relative' }}>
                    <div className="video-play">
                        <span className="video-play-icon" onClick={(event) => this.props.selectVideo(v)}></span>
                    </div>
                    <img className="ui image"
                        src={v.snippet.thumbnails.high.url}
                        onClick={(event) => this.props.selectVideo(v)} //! ok?
                    />
                </div>
            </div>);
    }
}

VideoList.propTypes = {
    videos: PropTypes.array.isRequired
};

const mapStateToProps = (state) => {
    return {
        isVideoFetching: state.videos.isVideoFetching,
        videos: state.videos.videos
    };
}

export default connect(mapStateToProps, { selectVideo })(VideoList);

