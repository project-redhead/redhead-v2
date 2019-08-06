import React from 'react';
import { BrowserRouter } from 'react-router-dom'

import Sidebar from './components/sidebar'
import Card from './components/card'

import './app.scss';

const App = () => {
	return (
		<div id="shell">
			<div id="sidebar">
				<Sidebar />
			</div>
			<div id="content">
				<h1>Hey Gino 👋</h1>
				<Card title="Aktuelle Wetten">
					Lädt...
				</Card>
			</div>
		</div>
	);
}

export default App;
