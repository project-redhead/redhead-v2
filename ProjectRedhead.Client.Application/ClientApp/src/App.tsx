import React from 'react';
import { BrowserRouter, Route, Redirect } from 'react-router-dom';

import Sidebar from './components/sidebar';
import Card from './components/card';

import AuthService from './common/services/auth';
import ConfigService from './common/services/config';

import { LoginPage, LoginCallbackPage } from './features/auth'

import './app.scss';

const App = () => {
	return (
		<div id="shell">
			<div id="sidebar">
				<Sidebar />
			</div>
			<div id="content">
				<BrowserRouter>
					{/* Global pages */}
					<>
						{/* Login pages */}
						<Route exact path="/login" component={LoginPage} />
						<Route path="/login/callback" component={LoginCallbackPage} />
					</>

					{/* Private pages */}
					<>
						{/* Member pages */}
						{AuthService.isTokenValid() &&
							<Route exact path="/" component={() => <span>Hello</span>} />
						}
					</>

					{/* Misc */}
					<>
						{/* Redirect to login */}
						{!AuthService.isTokenValid() &&
							<Redirect path="/" to="/login" />
						}
					</>
				</BrowserRouter>
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
