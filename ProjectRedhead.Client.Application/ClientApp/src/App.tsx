import React from 'react';
import { BrowserRouter } from 'react-router-dom'

import Sidebar from './components/sidebar'

import './app.scss';

const App = () => {
	return (
		<div id="shell">
			<div id="sidebar">
				<Sidebar />
			</div>
			<div id="content">

			</div>
		</div>
	);
}

export default App;
