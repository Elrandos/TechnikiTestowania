import React, { Component } from 'react';
import VideoList from './VideoList';
import { connect } from 'react-redux';
import { fetchVideos, onSearchTermChanged, setIsFetching } from '../actions';
import MainVideo from './MainVideo';

class App extends Component {
    render() {
        return (
            <div className="ui container stackable two column grid">
                <div className="ui row">
                    <div className="column eight wide">
                        <form className="ui form" onSubmit={(event) => this.onSearchSubmit(event)}>
                            <div className="field">
                                <div className="ui action input">
                                    <input type="text" onChange={(event) => this.onSearchTermChange(event)} placeholder="Plase enter the phrase" />
                                    <button className="ui button">Search</button>
                                </div>
                            </div>
                        </form>
                        <div className="ui hidden divider"></div>
                    </div>
                </div>
                <div className="ui row">
                    <div className="column ten wide">
                        <MainVideo />
                    </div>
                    <div className="column six wide">
                        <VideoList />
                    </div>
                </div>
            </div>
        );
    }

    onSearchTermChange(event) {
        this.props.onSearchTermChanged(event.target.value);
    }

    onSearchSubmit(event) {
        event.preventDefault();
        this.props.setIsFetching(true);
        this.props.fetchVideos();
    }
}

const mapsStateToProps = (state) => {
    return { searchTerm: state.searchTerm };
}

export default connect(mapsStateToProps, { onSearchTermChanged, fetchVideos, setIsFetching })(App);