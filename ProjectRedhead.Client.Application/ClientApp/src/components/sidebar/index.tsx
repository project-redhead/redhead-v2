import React from 'react';

import './sidebar.scss';
import { Link } from 'react-router-dom';

const Sidebar = () => {
	return (
		<div className="sidebar-container">
			<SidebarItem to="/bets" iconName="trophy" isSecondary={true} />
			<SidebarItem to="/" iconName="calendar-alt" />
			<SidebarItem to="/" iconName="home-alt" />
			<SidebarItem to="/" iconName="metro" />
			<SidebarItem to="/" iconName="utensils" isSecondary={true} />
		</div>
	)
};

const SidebarItem = (props: { iconName: string, to: string, isSecondary?: boolean }) => (
	<Link to={props.to} className={'item ' + ((props.isSecondary === true) ? 'secondary' : '')}>
		<i className={'uil uil-' + props.iconName}></i>
	</Link>
);

export default Sidebar;
