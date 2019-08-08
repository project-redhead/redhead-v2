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
				<h1>Hey Gino 👋</h1>

				<div className="grid-container">
					<div className="item w-4">
						<div className="gap">
							<Card>Test</Card>
						</div>
					</div>
					<div className="item w-4">
						<div className="gap">
							<Card>Test</Card>
						</div>
					</div>
					<div className="item w-4">
						<div className="gap">
							<Card>Test</Card>
						</div>
					</div>
					<div className="item w-4">
						<div className="gap">
							<Card>Test</Card>
						</div>
					</div>
					<div className="item w-4">
						<div className="gap">
							<Card>Test</Card>
						</div>
					</div>
					<div className="item w-4">
						<div className="gap">
							<Card>Test</Card>
						</div>
					</div>
				</div>
			</div>
		</div>
	);
}

export default App;
