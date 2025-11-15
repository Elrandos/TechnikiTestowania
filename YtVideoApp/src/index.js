import React from 'react';
import {createStore, applyMiddleware} from 'redux';
import ReactDom from 'react-dom';
import App from './components/App'
import {Provider} from 'react-redux'; //!
import reducers from './reducers';
import thunk from 'redux-thunk';

ReactDom.render(
    <Provider store={createStore(reducers,  applyMiddleware(thunk))}>
        <App />
    </Provider>,
    document.getElementById("root"))
