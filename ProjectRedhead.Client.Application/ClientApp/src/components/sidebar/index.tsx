import React from 'react';

import './sidebar.scss';

const Sidebar = () => {
	return (
		<div className="sidebar-container">
			<SidebarItem iconName="trophy" isSecondary={true} />
			<SidebarItem iconName="calendar-alt" />
			<SidebarItem iconName="home-alt" />
			<SidebarItem iconName="metro" />
			<SidebarItem iconName="utensils" isSecondary={true} />
		</div>
	)
};

const SidebarItem = (props: { iconName: string, isSecondary?: boolean }) => (
	<a className={'item ' + ((props.isSecondary === true) ? 'secondary' : '')}>
		<i className={'uil uil-' + props.iconName}></i>
	</a>
);

export default Sidebar;
