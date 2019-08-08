import React from 'react';

import AppRouter from './app-router'

import Sidebar from './components/sidebar';
import Card from './components/card';

import './app.scss';

const App = () => {
	return (
		<div id="shell">
			<div id="sidebar">
				<Sidebar />
			</div>
			<div id="content">
				<AppRouter />
			</div>
		</div>
	);
}

export default App;
