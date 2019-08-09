import React from 'react';

import AppRouterSwitch from './app-router'

import Sidebar from './components/sidebar';
import Card from './components/card';

import './app.scss';
import { BrowserRouter } from 'react-router-dom';

const App = () => {
	return (
		<BrowserRouter>
			<div id="shell">
				<div id="sidebar">
					<Sidebar />
				</div>
				<div id="content">
					<AppRouterSwitch />
				</div>
			</div>
		</BrowserRouter>
	);
}

export default App;
